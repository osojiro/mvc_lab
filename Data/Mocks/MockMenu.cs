using Microsoft.AspNetCore.Mvc.Formatters;
using noo.Data.Interfaces;
using noo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace noo.Data.Mocks
{
    public class MockMenu : IMenu
    {
        private readonly ICategory _caregory = new MockCategory();
        public IEnumerable<Menu> Menus 
        {  get           
            {
                return new List<Menu>
                {
                    new Menu {
                              name = "Салат с ростбифом",
                              img = "/img/2.jpg",
                              price = 176, 
                              shortDesc = "с рукколой, вяленными томатами, пармезаном и соусом Песто", 
                              IsFavorite = true,  
                              available = true,
                              Category = _caregory.AllCategories.First()
                    },
                     new Menu {
                              name = "Крем-суп из креветок",
                              img = "/img/1.jpg",
                              price = 122,
                              shortDesc = "нежный сливочный суп из креветок",
                              IsFavorite = true,
                              available = true,
                              Category = _caregory.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Menu> getFavMenu { get; set; }
        public Menu getObjectMenu(int id)
        {
            throw new NotImplementedException();
        }
    }
}
