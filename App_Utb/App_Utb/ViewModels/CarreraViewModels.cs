using System.Collections.Generic;
using System.Linq;

namespace App_Utb
{
    class CarreraViewModels
    {
        public List<Carrera> ListaCarreras { get; set; }
        public Carrera carrera { get; set; }
        public CarreraViewModels()
        {
            ListaCarreras lista
                = new ListaCarreras();
            ListaCarreras = lista.GetAll().ToList();
        }

        internal Carrera SeleccionarCarrera(int i)
        {
            ListaCarreras lista
                 = new ListaCarreras();
            ListaCarreras = lista.GetAll().ToList();

            Carrera carrer = new Carrera(ListaCarreras[i].imagen, ListaCarreras[i].nombre, ListaCarreras[i].descripcion, ListaCarreras[i].pProfecional, ListaCarreras[i].cLaboral, ListaCarreras[i].titulacion, ListaCarreras[i].mcurricular1, ListaCarreras[i].mcurricular2, ListaCarreras[i].icono, ListaCarreras[i].licen, ListaCarreras[i].malla1, ListaCarreras[i].malla2, ListaCarreras[i].imanuevo);
            carrera = carrer;

            return carrera;
        }
    }
}
