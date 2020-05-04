using App_Utb.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace App_Utb.ViewModels
{
    class CarreraViewModelsSanta
    {
        public List<CarreraSanta> ListaCarrerasSanta { get; set; }
        public CarreraSanta carrera { get; set; }
        public CarreraViewModelsSanta()
        {
            ListaCarrerasSanta lista
                = new ListaCarrerasSanta();
            ListaCarrerasSanta = lista.GetAll().ToList();
        }

        internal CarreraSanta SeleccionarCarrera(int i)
        {
            ListaCarrerasSanta lista
                 = new ListaCarrerasSanta();
            ListaCarrerasSanta = lista.GetAll().ToList();

            CarreraSanta carrer = new CarreraSanta(ListaCarrerasSanta[i].imagen, ListaCarrerasSanta[i].nombre, ListaCarrerasSanta[i].descripcion, ListaCarrerasSanta[i].pProfecional, ListaCarrerasSanta[i].cLaboral, ListaCarrerasSanta[i].titulacion, ListaCarrerasSanta[i].mcurricular1, ListaCarrerasSanta[i].mcurricular2, ListaCarrerasSanta[i].icono, ListaCarrerasSanta[i].licen, ListaCarrerasSanta[i].malla1, ListaCarrerasSanta[i].malla2, ListaCarrerasSanta[i].imanuevo);
            carrera = carrer;

            return carrera;
        }
    }
}
