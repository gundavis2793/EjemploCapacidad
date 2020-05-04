using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Utb.Modelos
{
    public class Materia
    {
        public Materias_Estudiante[] materias_estudiante { get; set; }
        public int success { get; set; }
    }

    public class Materias_Estudiante
    {
        public string validado { get; set; }
        public int id_asigdoc { get; set; }
        public int id_inscripcion { get; set; }
        public string nombre_carrera { get; set; }
        public string sede { get; set; }
        public string unidad_academica { get; set; }
        public string sigla { get; set; }
        public string descricion { get; set; }
        public string paralelo { get; set; }
        public string turno { get; set; }
        public string gestion { get; set; }
        public string periodo { get; set; }
        public string ap_pat_estudiante { get; set; }
        public string ap_mat_estudiante { get; set; }
        public string nombre_estudiante { get; set; }
        public int nota_asistencia1 { get; set; }
        public int nota_practicas1 { get; set; }
        public int nota_examen1 { get; set; }
        public int nota_1 { get; set; }
        public int nota_asistencia2 { get; set; }
        public int nota_practicas2 { get; set; }
        public int nota_examen2 { get; set; }
        public int nota_2 { get; set; }
        public int nota_examen_final { get; set; }
        public int nota2 { get; set; }
        public int notaf { get; set; }
        public string ap_pat_docente { get; set; }
        public string ap_mat_docente { get; set; }
        public string nombre_docente { get; set; }
    }
}
