using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;
using System.Security.Cryptography;
using WindowsFormsApp1.Statics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Lütfen boş alan barakmayınız");
            }
            else
            {
                SqlConnection baglanti = new SqlConnection(PistStatics.ConnectionString);
                baglanti.Open();

                string userName = textBox1.Text; //metni alır ve bu metni userName adlı bir string değişkeninde saklar.
                string password = textBox2.Text;
                string sql = string.Format($"select [Id], [KullaniciAdi], [Ad], [Soyad], [FotografUrl], [KayitTarihi], [Aktif] from Kullanici where KullaniciAdi = '{userName}' AND KullaniciSifresi = '{password}' ");
                //veritabanındaki "Kullanici" tablosundan belirli bir kullanıcının bilgilerini sorgulamak için

               SqlCommand komut = new SqlCommand(sql, baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                //Bu kod, bir SqlCommand ve bir SqlDataReader nesnesi kullanarak
                //SQL Server veritabanında bir sorguyu yürüten ve elde edilen sonuçları okur

                 if (oku.Read()) //Read metodu, sorgudan bir sonraki satırı okuduğu zaman true değerini döner,
                                 //okuyacak bir şey kalmadığında ise false döner.
                {
                    MessageBox.Show("Hoşgeldin " + userName);

                    var user = new UserDto(); // DTO'lar, genellikle veri transferi amacıyla kullanılan sınıflardır.
                                              //kullanıcının verilerine erişebilir veya bu verilere değerler atanabilir.
                                 //"var" anahtar kelimesi ile bir değişkenin tipini otomatik olarak belirleme anlamına gelir


                    user.Id = Convert.ToInt32(oku[0].ToString()); //oku[0]: Bu ifade, SqlDataReader nesnesinden, sorgudan dönen sonuçlardaki ilk sütunudur ıd
                                           //Convert.ToInt32(...): Bu ifade, bir değeri bir int türüne dönüştürmek için
                    user.KullaniciAdi = oku[1].ToString(); //ToString(): Bu metot, okunan değeri bir string'e dönüştürür.
                    user.Ad = oku[2].ToString();
                    user.Soyad = oku[3].ToString();
                    user.FotografUrl = oku[4].ToString();
                    PistStatics.LoggedUser = user;
                        //PistStatics adlı bir statik sınıfın içinde bulunan LoggedUser adlı bir özelliği temsil eder.
                        //oturum açmış kullanıcının bilgilerini taşıyan bir UserDto nesnesini içerebilir.

                    Form4 frm = new Form4();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre");
                }

                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show()        }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Login();
        }
    }
}
