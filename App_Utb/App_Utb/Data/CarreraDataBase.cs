using App_Utb.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Utb.Data
{
    class CarreraDatabase
    {
        public SQLiteConnection database;
        public CarreraDatabase(string dbPath)
        {


            database = new SQLiteConnection(dbPath);
            database.CreateTable<Carreras_Estudiante>();
        }
        public void InsertCarrera(Carreras_Estudiante usuario)
        {
            database.Insert(usuario);
        }
        public List<Carreras_Estudiante> ListaporCarrera(string id)
        {
            string query = "SELECT * FROM [Carreras_Estudiante] WHERE [nombre_carrera] like " + "'" + id + "'";
            return database.Query<Carreras_Estudiante>(query);
        }
        public void UpDateCarrera(Carreras_Estudiante usuario)
        {
            database.Update(usuario);
        }
        public void DeleteAll()
        {
            database.DeleteAll<Carreras_Estudiante>();
        }
        public void DeleteCarrera(Carreras_Estudiante usuario)
        {
            database.Delete(usuario);
        }

        public List<Carreras_Estudiante> GetCarreras()
        {
            return database.Table<Carreras_Estudiante>().ToList();
        }
        public void Dispose()
        {
            database.Dispose();
        }
    }
}
