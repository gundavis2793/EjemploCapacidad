using System;
using System.Collections.Generic;
using System.Text;

namespace App_Utb.Modelos
{

    public class ListaEstudiantes
    {
        public Lista_Estudiantes_Materia[] lista_estudiantes_materia { get; set; }
        public int success { get; set; }
    }

    public class Lista_Estudiantes_Materia
    {
        public string validado { get; set; }
        public int id_inscrito { get; set; }
        public int id_member_carrera { get; set; }
        public int id_materia_habilitada { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public string nombre { get; set; }
        public string carnet { get; set; }
    }

}
