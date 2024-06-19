using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PastaneMenuVeSiparis.Models
{
    [Table("tblSiparisDetaylar")]
    public class SiparisDetay
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [ForeignKey(typeof(Urun))]
        public int UrunId { get; set; }
        [ManyToOne(CascadeOperations = CascadeOperation.All)]
        public Urun Urun { get; set; }
        [ForeignKey(typeof(Siparis))]
        public int SiparisId { get; set; }
        [ManyToOne(CascadeOperations = CascadeOperation.All)]
        public Siparis Siparis { get; set; }
        public int Adet { get; set; }
        public decimal Tutar { get; set; }
    }
}
