using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace noo.Data.Models
{
    public class Menu
    {
        public int id { set; get; }
        public string name { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public string shortDesc { set; get; }
        public bool IsFavorite { set; get; }
        public bool available { set; get; }
        public int categoryId { set; get; }
        public virtual Category Category { set; get; }
    }
}
