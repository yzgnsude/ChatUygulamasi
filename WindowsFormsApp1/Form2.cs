using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1.Statics;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Kaydet()
        {
            if (textBoxKullaniciAdi.Text == "" || textBoxSifre.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurun");
                return;
            }

            SqlConnection baglanti = new SqlConnection(PistStatics.ConnectionString);
            baglanti.Open();
            string sql = string.Format($"select * from Kullanici where KullaniciAdi = '{textBoxKullaniciAdi.Text}' ");

            SqlCommand komut = new SqlCommand(sql, baglanti);
            var result = komut.ExecuteReader();
            if (result.Read())
            {
                result.Close();
                MessageBox.Show("KUllanici var");
                return;
            }
            else
            {
                result.Close();

                sql = string.Format($@"insert into [dbo].[Kullanici] ([KullaniciAdi], [KullaniciSifresi], [Ad], [Soyad], [KayitTarihi], [Aktif]) 
                    values ('{textBoxKullaniciAdi.Text}', '{textBoxSifre.Text}', '{textBoxAd.Text}', '{textBoxSoyad.Text}', GETDATE(), 1) ");

                SqlCommand komut2 = new SqlCommand(sql, baglanti);
                var insertResult = komut2.ExecuteNonQuery();
                if (insertResult > 0)
                {
                    MessageBox.Show("Kaydedildi");
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
