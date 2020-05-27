using noo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace noo.ViewModels
{
    public class MenuListViewModel
    { 
        public IEnumerable<Menu> allMenu { get; set; }
        public string MenuCategory { get; set; }
    }
}
