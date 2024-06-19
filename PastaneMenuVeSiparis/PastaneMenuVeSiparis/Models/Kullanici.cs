using PastaneMenuVeSiparis.Models.Enums;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PastaneMenuVeSiparis.Models
{
    [Table("tblKullanicilar")]
    public class Kullanici
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string AdSoyad { get { return Isim + " " + Soyisim; } }
        public Yetkiler Yetki { get; set; }
    }
}
