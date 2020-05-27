using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using noo.Data.Interfaces;
using noo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace noo.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenu _allMenu;
        private readonly ICategory _allCategories;

        public MenuController(IMenu imenu, ICategory icat)
        {
            _allMenu = imenu;
            _allCategories = icat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница меню";
            MenuListViewModel obj = new MenuListViewModel();
            obj.allMenu = _allMenu.Menus;
            obj.MenuCategory = "Меню";
            return View(obj);
        }
    }
}
