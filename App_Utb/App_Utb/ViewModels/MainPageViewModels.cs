using System.Collections.Generic;
using System.Linq;

namespace App_Utb
{
    class MainPageViewModels
    {
        public List<MenuItem> menuItems { get; set; }

        public MainPageViewModels()
        {
            ListaMenuItems lista
                = new ListaMenuItems();
            menuItems = lista.GetAll().ToList();
        }
    }
}
