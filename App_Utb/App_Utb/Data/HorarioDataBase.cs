using App_Utb.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Utb.Data
{
    class HorarioDataBase
    {
        public SQLiteConnection database;
        public HorarioDataBase(string dbPath)
        {database = new SQLiteConnection(dbPath);
            database.CreateTable<Horarios_Aula_Estudiante>();
        }
        public void InsertHorarios(Horarios_Aula_Estudiante usuario)
        {
            database.Insert(usuario);
        }
        public void UpDateHorario(Horarios_Aula_Estudiante usuario)
        {
            database.Update(usuario);
        }
        public void DeleteAll()
        {
            database.DeleteAll<Horarios_Aula_Estudiante>();
        }
        public void DeleteHorario(Horarios_Aula_Estudiante usuario)
        {
            database.Delete(usuario);
        }
        public List<Horarios_Aula_Estudiante> ListaporMateria(int id)
        {
            string query = "SELECT * FROM [Horarios_Aula_Estudiante] WHERE [id_asignacion_docente] = " + id;
            return database.Query<Horarios_Aula_Estudiante>(query);
        }
        public List<Horarios_Aula_Estudiante> GetHorarios()
        {
            return database.Table<Horarios_Aula_Estudiante>().ToList();
        }
        public void Dispose()
        {
            database.Dispose();
        }
    }
}
