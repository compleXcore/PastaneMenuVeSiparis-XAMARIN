using PastaneMenuVeSiparis.Models.Enums;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;

namespace PastaneMenuVeSiparis.Models
{
    [Table("tblSiparisler")]
    public class Siparis
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [ForeignKey(typeof(Kullanici))]
        public int KullaniciId { get; set; }
        [ManyToOne(CascadeOperations = CascadeOperation.All)]
        public Kullanici Kullanici { get; set; }
        
        public Durumlar Durum { get; set; }
        public decimal ToplamFiyat { get; set; }
        public DateTime Tarih { get; set; }
    }
}
