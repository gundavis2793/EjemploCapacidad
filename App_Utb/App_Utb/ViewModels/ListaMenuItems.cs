using System.Collections.Generic;


namespace App_Utb
{
    public class ListaMenuItems
    {
        public IList<MenuItem> menuItems { get; set; }
        public ListaMenuItems()
        {
            menuItems = new List<MenuItem>();

            MenuItem itm = new MenuItem("Usuario", "MenuIconUsuario");

            MenuItem itm3 = new MenuItem("Acerca De...", "MenuIconInfo");


            MenuItem itm4 = new MenuItem("Configuracion", "MenuIconConfig");
            MenuItem itm5 = new MenuItem("Cerrar Sesion", "MenuIconCerrar");
            menuItems.Add(itm);


            menuItems.Add(itm3);
            menuItems.Add(itm4);
            menuItems.Add(itm5);

        }
        public IList<MenuItem> GetAll()
        {
            return (menuItems);
        }


    }

}
