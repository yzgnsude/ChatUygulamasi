using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using WindowsFormsApp1.Statics;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form

    {
        private Form4 form4Instance;
        public Form6(Form4 existingForm4)
        {
            InitializeComponent();
            form4Instance = existingForm4;

            LoadData();
        }

        List<IsteklerDto> ListGonderdiklerim = new List<IsteklerDto>();
        List<IsteklerDto> ListGelenler = new List<IsteklerDto>();
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(PistStatics.ConnectionString))
            {
                connection.Open();

                string queryGonderdiklerim = @"
SELECT * 
,(select k.KullaniciAdi from Kullanici k where k.Id = i.[GonderenKullaniciId]) as ex_GonderenKullaniciAd
,(select k.KullaniciAdi from Kullanici k where k.Id = i.AliciKullaniciId) as ex_AliciKullaniciAd
FROM Istekler as i 
WHERE Durumu = 1 AND GonderenKullaniciId = " + PistStatics.LoggedUser.Id.ToString();
                using (SqlCommand command = new SqlCommand(queryGonderdiklerim, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var istek = new IsteklerDto()
                            {
                                Id = (int)reader["Id"],
                                GonderenKullaniciId = (int)reader["GonderenKullaniciId"],
                                AliciKullaniciId = (int)reader["AliciKullaniciId"],
                            };
                            if (!string.IsNullOrEmpty(reader["IstekZamani"].ToString()))
                                istek.IstekZamani = Convert.ToDateTime(reader["IstekZamani"]);
                            if (!string.IsNullOrEmpty(reader["SonIslemZamani"].ToString()))
                                istek.SonIslemZamani = Convert.ToDateTime(reader["SonIslemZamani"]);
                            if (!string.IsNullOrEmpty(reader["Durumu"].ToString()))
                                istek.Durumu = (IstekDurumIds)Convert.ToInt32(reader["Durumu"]);
                            istek.ex_AliciKullaniciAd = reader["ex_AliciKullaniciAd"].ToString();
                            istek.ex_GonderenKullaniciAd = reader["ex_GonderenKullaniciAd"].ToString();

                            ListGonderdiklerim.Add(istek);
                        }
                    }
                }


                string queryGelenler = @"
SELECT * 
,(select k.KullaniciAdi from Kullanici k where k.Id = i.[GonderenKullaniciId]) as ex_GonderenKullaniciAd
,(select k.KullaniciAdi from Kullanici k where k.Id = i.AliciKullaniciId) as ex_AliciKullaniciAd
FROM Istekler as i 
WHERE Durumu = 1 AND AliciKullaniciId = " + PistStatics.LoggedUser.Id.ToString();
                using (SqlCommand command = new SqlCommand(queryGelenler, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var istek = new IsteklerDto()
                            {
                                Id = (int)reader["Id"],
                                GonderenKullaniciId = (int)reader["GonderenKullaniciId"],
                                AliciKullaniciId = (int)reader["AliciKullaniciId"],
                            };
                            if (!string.IsNullOrEmpty(reader["IstekZamani"].ToString()))
                                istek.IstekZamani = Convert.ToDateTime(reader["IstekZamani"]);
                            if (!string.IsNullOrEmpty(reader["SonIslemZamani"].ToString()))
                                istek.SonIslemZamani = Convert.ToDateTime(reader["SonIslemZamani"]);
                            if (!string.IsNullOrEmpty(reader["Durumu"].ToString()))
                                istek.Durumu = (IstekDurumIds)Convert.ToInt32(reader["Durumu"]);
                            istek.ex_AliciKullaniciAd = reader["ex_AliciKullaniciAd"].ToString();
                            istek.ex_GonderenKullaniciAd = reader["ex_GonderenKullaniciAd"].ToString();

                            ListGelenler.Add(istek);
                        }
                    }
                }
            }

            dataGridGonderdiklerim.DataSource = ListGonderdiklerim;
            dataGridGelenler.DataSource = ListGelenler;

            dataGridGonderdiklerim.Refresh();
            dataGridGelenler.Refresh();
        }

        private void IstekYolla()
        {
            using (SqlConnection connection = new SqlConnection(PistStatics.ConnectionString))
            {
                connection.Open();

                // arkadaşlık kontrol sorgusu 
                string checkQuery = string.Format(@"
select COUNT(*) from  [dbo].[Arkadaslik] a
inner join [dbo].[Kullanici] k on k.Id = a.FriendUserId
where a.UserId  = {0} AND k.KullaniciAdi = '{0}' ", PistStatics.LoggedUser.Id, txtKullaniciIsmi.Text);

                string userQuery = string.Format("select top 1 Id from Kullanici where KullaniciAdi = '{0}'", txtKullaniciIsmi.Text);
                int arkadas = 0;
                using (SqlCommand checkCommand = new SqlCommand(userQuery, connection))
                {
                    arkadas = (int)checkCommand.ExecuteScalar();
                }

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    int existingFriendshipCount = (int)checkCommand.ExecuteScalar();

                    if (existingFriendshipCount == 0)
                    {
                        string insertQuery = "INSERT INTO Istekler (GonderenKullaniciId, AliciKullaniciId,IstekZamani,Durumu) VALUES (@GonderenKullaniciId, @AliciKullaniciId,@IstekZamani,@Durumu)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@GonderenKullaniciId", PistStatics.LoggedUser.Id);
                            insertCommand.Parameters.AddWithValue("@AliciKullaniciId", arkadas);
                            insertCommand.Parameters.AddWithValue("@IstekZamani", DateTime.Now);
                            insertCommand.Parameters.AddWithValue("@Durumu", IstekDurumIds.Gonderildi);

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Zaten arkadaşsınız.");
                    }
                }
            }

            LoadData();
        }

        private void KabulEt()
        {
            var selectedRow = dataGridGelenler.CurrentRow.DataBoundItem as IsteklerDto;
            if (selectedRow != null)
            {
                using (SqlConnection connection = new SqlConnection(PistStatics.ConnectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Arkadaslik (UserId,FriendUserId) VALUES (@UserId, @FriendUserId)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@UserId", selectedRow.AliciKullaniciId);
                        insertCommand.Parameters.AddWithValue("@FriendUserId", selectedRow.GonderenKullaniciId);

                        insertCommand.ExecuteNonQuery();
                    }

                    string updateQuery = string.Format("Update Istekler set Durumu = {0} Where Id = {1}", (int)IstekDurumIds.KabulEdildi, selectedRow.Id);
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.ExecuteNonQuery();
                    }
                }
            }

            LoadData();
        }

        private void DeleteGelenIstek()
        {
            //TODO: data gridde (alttaki) seçili kaydın Id bilgisini bul yada seçili satırı IsteklerDto veri yapısına dönüştür

            // İstek tablosundaki kaydı güncelle
        }
        private void DeleteGidenIstek()
        {
            //TODO: data gridde (üsttteki) seçili kaydın Id bilgisini bul yada seçili satırı IsteklerDto veri yapısına dönüştür

            // İstek tablosundaki kaydı güncelle
        }

        private void btnIstekYolla_Click(object sender, EventArgs e)
        {
            IstekYolla();
        }

        private void dataGridGelenler_DoubleClick(object sender, EventArgs e)
        {
            KabulEt();
        }

        private void toolStripMenuItemGelenDelete_Click(object sender, EventArgs e)
        {
            DeleteGelenIstek();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteGidenIstek();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
