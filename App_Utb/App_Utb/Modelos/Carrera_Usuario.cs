using System;
using System.Collections.Generic;
using System.Text;

namespace App_Utb.Modelos
{
    public class Carrera_Usuario
    {
        public Carreras_Estudiante[] carreras_estudiante { get; set; }
        public int success { get; set; }
    }

    public class Carreras_Estudiante
    {
        public string validado { get; set; }
        public int id_member_carrera { get; set; }
        public string nombre_carrera { get; set; }
        public string unidad_academica { get; set; }
        public string sede_subsede { get; set; }
        public int numero_plan { get; set; }
        public string plan_estudios { get; set; }
    }
}




