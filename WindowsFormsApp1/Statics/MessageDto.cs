using System;

namespace WindowsFormsApp1.Statics
{
    public class MessageDto
    {
        public int Id { get; set; }

        public DateTime YazilmaTarihi { get; set; }

        public bool OkunduMu {  get; set; }

        //public Bit OkunduMu {  get; set; }

        //public Date OkunmaZamani { get; set; }

        public DateTime Time { get; set; }
        public DateTime OkunmaZamani { get; set; } 

        public int GonderenKullaniciId { get; set; }
        public int AliciKullaniciId { get; set; }
        public string Mesaj { get; set; }
        public int? GroupId { get; set; }
        public string MesajKey { get; set; }

    }
}
