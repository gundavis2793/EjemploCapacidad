using App_Utb.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Utb.Data
{
    class MateriaDataBase
    {
        public SQLiteConnection database;
        public MateriaDataBase(string dbPath)
        {


            database = new SQLiteConnection(dbPath);
            database.CreateTable<Materias_Estudiante>();
        }
        public void InsertMateria(Materias_Estudiante usuario)
        {
            database.Insert(usuario);
        }
        public void UpDateMateria(Materias_Estudiante usuario)
        {
            database.Update(usuario);
        }
        public void DeleteAll()
        {
            database.DeleteAll<Materias_Estudiante>();
        }
        public void DeleteMateria(Materias_Estudiante usuario)
        {
            database.Delete(usuario);
        }
        public List<Materias_Estudiante> ListaporCarrera(string id)
        {
            string query = "SELECT * FROM [Materias_Estudiante] WHERE [nombre_carrera] like " + "'"+id+"'";
            return database.Query<Materias_Estudiante>(query);
        }
        public List<Materias_Estudiante> GetUsuarios()
        {
            return database.Table<Materias_Estudiante>().ToList();
        }
        public void Dispose()
        {
            database.Dispose();
        }
    }
}
