using System;

namespace PastaneMenuVeSiparis.Models
{
    public class MenuItemModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Type TargetType { get; set; }
    }
}
