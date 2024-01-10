using System;

namespace WindowsFormsApp1.Statics
{
    public class IsteklerDto
    {
        public int Id { get; set; }
        public int GonderenKullaniciId { get; set; }
        public string ex_GonderenKullaniciAd { get; set; }
        public int AliciKullaniciId { get; set; }
        public string ex_AliciKullaniciAd { get; set; }
        public DateTime? IstekZamani { get; set; }
        public DateTime? SonIslemZamani { get; set; }
        public IstekDurumIds? Durumu { get; set; }

    }
}
