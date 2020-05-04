using App_Utb.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Utb.Data
{
    class UsuarioDatabase
    {
        public SQLiteConnection database;
        public UsuarioDatabase(string dbPath)
        {


            database = new SQLiteConnection(dbPath);
            database.CreateTable<Verificacion_Usuario>();
        }
        public void InsertUsuario(Verificacion_Usuario usuario)
        {
            database.Insert(usuario);
        }
        public void UpDateUsuario(Verificacion_Usuario usuario)
        {
            database.Update(usuario);
        }
        public void DeleteAll()
        {
            database.DeleteAll<Verificacion_Usuario>();
        }
        public void DeleteUsuario(Verificacion_Usuario usuario)
        {
            database.Delete(usuario);
        }
 
        public List<Verificacion_Usuario> GetUsuarios()
        {
            return database.Table<Verificacion_Usuario>().ToList();
        }
        public void Dispose()
        {
            database.Dispose();
        }
    }
}
