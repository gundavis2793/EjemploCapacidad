using System;
using System.Collections.Generic;
using System.Text;

namespace App_Utb.Modelos
{
    public class Horarios_Aula_Estudiante
    {
        public string validado { get; set; }
        public int id_hora { get; set; }
        public int id_asignacion_docente { get; set; }
        public string dia { get; set; }
        public string inicio { get; set; }
        public string final { get; set; }
        public string hrs_academicas { get; set; }
        public int nro_dia { get; set; }
        public string fecha_inicio { get; set; }
        //public object fecha_fin { get; set; }
        public string estado { get; set; }
        public string aula { get; set; }
        public string ubicacion { get; set; }
    }
}
