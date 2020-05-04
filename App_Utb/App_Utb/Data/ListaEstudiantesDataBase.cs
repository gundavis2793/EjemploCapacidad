using App_Utb.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App_Utb.Data
{
    class ListaEstudiantesDataBase
    {
        public SQLiteConnection database;
        public ListaEstudiantesDataBase(string dbPath)
        {


            database = new SQLiteConnection(dbPath);
            database.CreateTable<Lista_Estudiantes_Materia>();
        }
        public void InsertLista(Lista_Estudiantes_Materia usuario)
        {
            database.Insert(usuario);
        }
        public void UpDateLista(Lista_Estudiantes_Materia usuario)
        {
            database.Update(usuario);
        }
        public void DeleteAll()
        {
            database.DeleteAll<Lista_Estudiantes_Materia>();
        }
        public void DeleteLista(Lista_Estudiantes_Materia usuario)
        {
            database.Delete(usuario);
        }
        public void InsertAllLista(Lista_Estudiantes_Materia[] lista) {
            database.InsertAll(lista);
        }
        public List<Lista_Estudiantes_Materia> GetItemsNotDoneAsync(int id)
        {
            string query = "SELECT * FROM [Lista_Estudiantes_Materia] WHERE [id_materia_habilitada] = " + id ;
            return  database.Query<Lista_Estudiantes_Materia>(query);
        }
        public List<Lista_Estudiantes_Materia> GetListaEStudiantes()
        {
            return database.Table<Lista_Estudiantes_Materia>().ToList();
        }
        public void Dispose()
        {
            database.Dispose();
        }
    }
}
