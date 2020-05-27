using noo.Data.Interfaces;
using noo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace noo.Data.Mocks
{
    public class MockCategory : ICategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { name = "Салаты"},
                    new Category { name = "Супы"}
                };
            }
        }
    }
}
