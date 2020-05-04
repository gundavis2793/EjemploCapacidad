using System;
using System.Collections.Generic;
using System.Text;

namespace App_Utb.Modelos
{

    public class ListaMateriasDocente
    {
        public Materias_Docente[] materias_docente { get; set; }
        public int success { get; set; }
    }

    public class Materias_Docente
    {
        public string validado { get; set; }
        public int id_asigdoc { get; set; }
        public int id_materia_habilitada { get; set; }
        public string sede { get; set; }
        public string subsede { get; set; }
        public string nombre_carrera { get; set; }
        public string gestion { get; set; }
        public string periodo { get; set; }
        public string sigla { get; set; }
        public string descricion { get; set; }
        public string paralelo { get; set; }
        public string turno { get; set; }
        public int semestre { get; set; }
    }

}
