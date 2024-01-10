using System.Collections.Generic;

namespace WindowsFormsApp1.Statics
{
    public class UserDto
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string FotografUrl { get; set; }

        public List<UserDto> Friends { get; set; } = new List<UserDto>();   
    }
}
