using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace noo.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string name { set; get; }
        public List<Menu> menus { set; get; }
    }
}
