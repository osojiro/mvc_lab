using noo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace noo.Data.Interfaces
{
    public interface IMenu
    {
        IEnumerable<Menu> Menus { get; }
        IEnumerable<Menu> getFavMenu { get; set; }
        Menu getObjectMenu(int id);
    }
}
