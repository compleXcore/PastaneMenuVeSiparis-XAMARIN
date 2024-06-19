using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PastaneMenuVeSiparis.Models
{
    [Table("tblUrunler")]
    public class Urun
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Fiyat { get; set; }
        [ForeignKey(typeof(Kategori))]
        public int KategoriId { get; set; }
        [ManyToOne(CascadeOperations = CascadeOperation.All)]
        public Kategori Kategori { get; set; }
    }
}
