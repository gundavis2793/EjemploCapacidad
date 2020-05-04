using System.Collections.Generic;
using Xamarin.Forms.PlatformConfiguration;

namespace App_Utb
{

    public class Carrera
    {

        public string imagen { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string pProfecional { get; set; }
        public string cLaboral { get; set; }
        public string titulacion { get; set; }
        public string mcurricular1 { get; set; }
        public string mcurricular2 { get; set; }
        public string icono { get; set; }
        public string licen { get; set; }
        public string malla1 { get; set; }
        public string malla2 { get; set; }
        public string imanuevo { get; set; }
        public List<string> ListaMalla { get; set; }

        public Carrera(string imagen, string nombre, string descripcion,
            string pProfecional, string cLaboral, string titulacion,
            string mcurricular1, string mcurricular2, string icono,
            string licen, string malla1, string malla2, string imanuevo
            )
        {
            this.imagen = imagen;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.pProfecional = pProfecional;
            this.cLaboral = cLaboral;
            this.titulacion = titulacion;
            this.mcurricular1 = mcurricular1;
            this.mcurricular2 = mcurricular2;
            this.icono = icono;
            this.licen = licen;
            this.malla1 = malla1;
            this.malla2 = malla2;
            this.imanuevo = imanuevo;
        }

    }
}
