using System;
using System.Collections.Generic;
using System.Text;

namespace App_Utb.Modelos
{
    public class Usuario
    {
        public Verificacion_Usuario[] verificacion_usuario { get; set; }
        public int success { get; set; }
    }

    public class Verificacion_Usuario
    {
        public string usuario { get; set; }
        public string validado { get; set; }
        public string rol { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public string nombre { get; set; }
        public string periodo { get; set; }
        public int gestion { get; set; }
        public int semestre_doc { get; set; }
        public int semestre_est { get; set; }
        public string avatar { get; set; }
    }
}




