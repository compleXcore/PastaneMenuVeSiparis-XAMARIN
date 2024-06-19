using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PastaneMenuVeSiparis.Models
{
    [Table("tblKategoriler")]
    public class Kategori
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Ad { get; set; }
    }
}
