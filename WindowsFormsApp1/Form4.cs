using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.Statics;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            LoadGroupsAndFriends();
        }

        List<GrupDto> gruplar = new List<GrupDto>();
        List<UserDto> kullanici = new List<UserDto>();
        List<MessageDto> currentMessages = new List<MessageDto>();
        object selectedItem;

        public void LoadGroupsAndFriends()
        {

            // Clear existing controls in the panel
            panelGroupsFriends.Controls.Clear();

            using (SqlConnection connection = new SqlConnection(PistStatics.ConnectionString))
            {
                connection.Open();

                // Load groups
                string groupQuery = "select gk.*,(select g.GrupIsmi from Gruplar g where g.Id = gk.GroupId) as GrupIsmi from [dbo].[GrupKullanici] gk where gk.KullaniciId = " + PistStatics.LoggedUser.Id.ToString();
                using (SqlCommand groupCommand = new SqlCommand(groupQuery, connection))
                using (SqlDataReader groupReader = groupCommand.ExecuteReader())
                {
                    while (groupReader.Read())
                    {
                        int groupId = (int)groupReader["GroupId"];
                        string groupName = groupReader["GrupIsmi"].ToString();

                        var group = new GrupDto() { GrupIsmi = groupName, Id = groupId };
                        gruplar.Add(group);

                        // Add group to the form
                        AddItem(group, null);
                    }
                }

                // Load user's friends
                LoadUserFriends(PistStatics.LoggedUser);

                // Display friends on the form
                foreach (var friend in PistStatics.LoggedUser.Friends)
                {
                    AddItem(null, friend);
                }
            }
        }

        public void AddItem(GrupDto grup, UserDto user)
        {
            Button btn = new Button();
            btn.Dock = DockStyle.Top;
            btn.Location = new System.Drawing.Point(0, 0);
            btn.Size = new System.Drawing.Size(325, 68);

            if (grup != null)
            {
                btn.Text = "(G) - " + grup.GrupIsmi;
                btn.Tag = grup;
            }
            else
            {
                btn.Text = "(A) - " + user.KullaniciAdi;
                btn.Tag = user;
            }
            btn.UseVisualStyleBackColor = true;
            btn.Click += Btn_Click;

            this.panelGroupsFriends.Controls.Add(btn);
        }


        private void LoadUserFriends(UserDto user)
        {
            user.Friends = GetFriendsFromDatabase(user.Id);
        }


        private List<UserDto> GetFriendsFromDatabase(int userId)
        {
            List<UserDto> friends = new List<UserDto>();

            using (SqlConnection connection = new SqlConnection(PistStatics.ConnectionString))
            {
                connection.Open();

                string query = @"select a.*,(select [KullaniciAdi] from [dbo].[Kullanici] k where k.Id = a.FriendUserId) as ArkadasIsmi 
                                 from [dbo].[Arkadaslik] a where a.UserId = @UserId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var friend = new UserDto()
                            {
                                Id = (int)reader["UserId"],
                                KullaniciAdi = reader["ArkadasIsmi"].ToString(),
                                // Add other properties as needed
                            };

                            friends.Add(friend);
                        }
                    }
                }


                string query2 = @"select a.*,(select [KullaniciAdi] from [dbo].[Kullanici] k where k.Id = a.UserId) as ArkadasIsmi 
                                 from [dbo].[Arkadaslik] a where a.FriendUserId = @UserId";

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var friend = new UserDto()
                            {
                                Id = (int)reader["UserId"],
                                KullaniciAdi = reader["ArkadasIsmi"].ToString(),
                                // Add other properties as needed
                            };

                            friends.Add(friend);
                        }
                    }
                }
            }

            return friends;
        }

        private void AddFriendToDatabase(int userId, int friendUserId)
        {
            using (SqlConnection connection = new SqlConnection(PistStatics.ConnectionString))
            {
                connection.Open();


                string checkQuery = "SELECT COUNT(*) FROM Arkadaslik WHERE UserId = @UserId AND FriendUserId = @FriendUserId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@UserId", userId);
                    checkCommand.Parameters.AddWithValue("@FriendUserId", friendUserId);

                    int existingFriendshipCount = (int)checkCommand.ExecuteScalar();

                    if (existingFriendshipCount == 0)
                    {

                        string insertQuery = "INSERT INTO Arkadaslik (UserId, FriendUserId) VALUES (@UserId, @FriendUserId) INSERT INTO Arkadaslik (UserId, FriendUserId) VALUES (@FriendUserId, @UserId)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@UserId", userId);
                            insertCommand.Parameters.AddWithValue("@FriendUserId", friendUserId);

                            insertCommand.ExecuteNonQuery();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Zaten arkadaşsınız.");
                    }
                }
            }
        }

        private void DeleteFriendToDatabase(int userId, int friendUserId)
        {
            using (SqlConnection connection = new SqlConnection(PistStatics.ConnectionString))
            {
                connection.Open();


                string checkQuery = "SELECT COUNT(*) FROM Arkadaslik WHERE UserId = @UserId AND FriendUserId = @FriendUserId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@UserId", userId);
                    checkCommand.Parameters.AddWithValue("@FriendUserId", friendUserId);

                    int existingFriendshipCount = (int)checkCommand.ExecuteScalar();

                    if (existingFriendshipCount == 1)
                    {

                        string insertQuery = "DELETE FROM Arkadaslik WHERE (UserId = @UserId AND FriendUserId = @FriendUserId) OR (UserId = @FriendUserId AND FriendUserId = @UserId);";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@UserId", userId);
                            insertCommand.Parameters.AddWithValue("@FriendUserId", friendUserId);

                            insertCommand.ExecuteNonQuery();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Zaten arkadaş değilsiniz.");
                    }
                }
            }
        }

        public void DeleteFriend(UserDto user, string friendUsername)
        {
            UserDto friend = GetUserByUsername(friendUsername);

            if (friend != null)
            {
                // Add the friend to the user's friend list in the database
                DeleteFriendToDatabase(user.Id, friend.Id);

                // Update the user's friend list
                LoadUserFriends(user);

                // Display the updated friend list on the form
                foreach (var updatedFriend in user.Friends)
                {
                    AddItem(null, updatedFriend);
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunmamakta.");
            }
            LoadGroupsAndFriends();
        }


        public void AddFriend(UserDto user, string friendUsername)
        {
            // Retrieve the friend's UserDto from the database based on the username
            UserDto friend = GetUserByUsername(friendUsername);

            if (friend != null)
            {
                // Add the friend to the user's friend list in the database
                AddFriendToDatabase(user.Id, friend.Id);

                // Update the user's friend list
                LoadUserFriends(user);

                // Display the updated friend list on the form
                foreach (var updatedFriend in user.Friends)
                {
                    AddItem(null, updatedFriend);
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunmamakta.");
            }
            LoadGroupsAndFriends();
        }


        private UserDto GetUserByUsername(string username)
        {
            using (SqlConnection connection = new SqlConnection(PistStatics.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Kullanici WHERE KullaniciAdi = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var user = new UserDto()
                            {
                                Id = (int)reader["Id"],
                                KullaniciAdi = reader["KullaniciAdi"].ToString(),
                                // Add other properties as needed
                            };

                            return user;
                        }
                    }
                }
            }
            return null;
        }
        private void LoadMessages(object obj)
        {
            rtfMessages.Clear();
            currentMessages.Clear();

            if (obj is GrupDto)
            {
                LoadGroupMessages(obj as GrupDto);
            }
            else
            {
                LoadUserMessages();
            }

            PrintMessages();
        }

        private void LoadUserMessages()
        {
            using (SqlConnection connection = new SqlConnection(PistStatics.ConnectionString))
            {
                connection.Open();

                //TODO: aşağıdaki sorguya uyan kayıtların OkunduMu alanını true yap

                // Mesajları çekme sorgusu
                string query = string.Format("SELECT * FROM Mesajlar WHERE ((AliciKullaniciId = {0} AND GonderenKullaniciId = {1}) OR (AliciKullaniciId = {1} AND GonderenKullaniciId = {0})) AND GroupId is null ORDER BY YazilmaTarihi",
                        PistStatics.LoggedUser.Id, (selectedItem as UserDto).Id);

                using (SqlCommand groupCommand = new SqlCommand(query, connection))
                using (SqlDataReader messageReader = groupCommand.ExecuteReader())
                {
                    while (messageReader.Read())
                    {
                        var message = new MessageDto()
                        {
                            Id = (int)messageReader["Id"],
                            AliciKullaniciId = (int)messageReader["AliciKullaniciId"],
                            GonderenKullaniciId = (int)messageReader["GonderenKullaniciId"],
                            Mesaj = messageReader["Mesaj"].ToString(),
                            YazilmaTarihi = (DateTime)messageReader["YazilmaTarihi"]
                        };
                        currentMessages.Add(message);
                    }
                }
            }
        }

        private void LoadGroupMessages(GrupDto grup)
        {
            using (SqlConnection connection = new SqlConnection(PistStatics.ConnectionString))
            {
                connection.Open();

                // Grupları çekme
                string query = string.Format("SELECT * FROM Mesajlar WHERE GroupId = {0} ORDER BY YazilmaTarihi", grup.Id);

                string Query = string.Format("SELECT * FROM Mesajlar WHERE (GonderenKullaniciId = {0} OR AliciKullaniciId = {0}) AND GroupId = {1} ORDER BY YazilmaTarihi",
                    PistStatics.LoggedUser.Id, grup.Id);

                List<string> loadedMessages = new List<string>();

                using (SqlCommand groupCommand = new SqlCommand(query, connection))
                using (SqlDataReader messageReader = groupCommand.ExecuteReader())
                {
                    while (messageReader.Read())
                    {
                        var message = new MessageDto()
                        {
                            Id = (int)messageReader["Id"],
                            AliciKullaniciId = (int)messageReader["AliciKullaniciId"],
                            GonderenKullaniciId = (int)messageReader["GonderenKullaniciId"],
                            Mesaj = messageReader["Mesaj"].ToString(),
                            GroupId = (int?)messageReader["GroupId"],
                            MesajKey = messageReader["MesajKey"].ToString(),
                            YazilmaTarihi = (DateTime)messageReader["YazilmaTarihi"]
                        };


                        if (!loadedMessages.Contains(message.MesajKey)) //if loadedMessages" koleksiyonunun içinde "message.MesajKey" değeri bulunmuyorsa,                                                                     
                                                                        //ifade true olur ve bu durumda if bloğu çalıştırılır. Eğer değer bulunursa,
                                                                        //ifade false olur ve if bloğu atlanır.
                        {
                            currentMessages.Add(message);
                            loadedMessages.Add(message.MesajKey);

                            // Debug Output
                        }
                    }
                }
            }
        }

        private void PrintMessages()
        {
            rtfMessages.Clear();

            foreach (var message in currentMessages)
            {
                var senderName = message.GonderenKullaniciId == PistStatics.LoggedUser.Id
                    ? PistStatics.LoggedUser.KullaniciAdi
                    : kullanici.FirstOrDefault(c => c.Id == message.GonderenKullaniciId)?.KullaniciAdi;

                if (message.GonderenKullaniciId == PistStatics.LoggedUser.Id)
                {
                    PrintMessage($"{senderName} :  >> {message.Mesaj}  {Environment.NewLine}", Color.Blue, message.YazilmaTarihi);
                }
                else
                {
                    PrintMessage($"{senderName} :  << {message.Mesaj} {Environment.NewLine}", Color.Green, message.YazilmaTarihi);
                }
            }
        }

        private void PrintMessage(string message, Color color, DateTime dateTime)
        {
            int startIndex = rtfMessages.TextLength;

            rtfMessages.AppendText($"{dateTime}: {message}");


            int endIndex = rtfMessages.TextLength;

            // İlgili mesajın rengini değiştir
            rtfMessages.Select(startIndex, endIndex - startIndex);
            rtfMessages.SelectionColor = color;

            // Metin sonuna git
            rtfMessages.SelectionStart = rtfMessages.TextLength;
            rtfMessages.ScrollToCaret();
        }

        private void SendMessage()
        {
            if (selectedItem is UserDto)  // User sınıfı, seçilen öğenin bir kullanıcı olduğunu temsil ediyor
            {
                // Kullanıcıya mesaj gönderme işlemi
                SendMessageToUser(selectedItem as UserDto);
            }
            else if (selectedItem is GrupDto)  // Group sınıfı, seçilen öğenin bir grup olduğunu temsil ediyor
            {
                // Gruba mesaj gönderme işlemi
                SendMessageToGroup(selectedItem as GrupDto);
            }

            LoadMessages(selectedItem);
        }

        private void SendMessageToUser(UserDto selectedUser)
        {
            using (SqlConnection connection = new SqlConnection(PistStatics.ConnectionString))
            {
                connection.Open();

                string insertQuery = string.Format(@" INSERT INTO Mesajlar ([YazilmaTarihi], [GonderenKullaniciId], [AliciKullaniciId], [Mesaj]) VALUES (GETDATE(), {0},{1},'{2}')",


                    PistStatics.LoggedUser.Id, selectedUser.Id, txtMesaj.Text);

                using (SqlCommand groupCommand = new SqlCommand(insertQuery, connection))
                {
                    var result = groupCommand.ExecuteNonQuery();
                }
            }

            txtMesaj.Text = "";
        }

        private void SendMessageToGroup(GrupDto selectedGroup)
        {
            using (SqlConnection connection = new SqlConnection(PistStatics.ConnectionString))
            {
                connection.Open();

                List<int> groupUsers = new List<int>();
                string groupUsersSql = "select * from [dbo].[GrupKullanici] where [GroupId] = " + selectedGroup.Id.ToString();
                using (SqlCommand groupCommand = new SqlCommand(groupUsersSql, connection))
                using (SqlDataReader messageReader = groupCommand.ExecuteReader())
                {
                    while (messageReader.Read())
                    {
                        groupUsers.Add((int)messageReader["KullaniciId"]);
                    }
                }

                var key = Guid.NewGuid().ToString();
                foreach (var sender in groupUsers)
                {
                    string insertQuery = string.Format(@"INSERT INTO Mesajlar ([YazilmaTarihi], [GonderenKullaniciId], [AliciKullaniciId], [Mesaj], [GroupId], [MesajKey]) 
VALUES (GETDATE(), {0},{1},'{2}',{3},'{4}')",

               PistStatics.LoggedUser.Id, sender, txtMesaj.Text, selectedGroup.Id, key);

                    using (SqlCommand groupCommand = new SqlCommand(insertQuery, connection))
                    {
                        var result = groupCommand.ExecuteNonQuery();
                    }
                }
            }

            txtMesaj.Text = "";
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            selectedItem = (sender as Button).Tag;
            LoadMessages(selectedItem);
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this);
            form6.Show();
        }

        private void groupBoxGroupsFriends_Enter(object sender, EventArgs e)
        {

        }
    }

}
