using App_Utb.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Utb.Data
{
    public class NoticiaDatabase
    {
        public SQLiteConnection database;
        public NoticiaDatabase(string dbPath)
        {


            database = new SQLiteConnection(dbPath);
            database.CreateTable<Noticia>();
        }
        public void InsertNoti(Noticia noticia)
        {
            database.Insert(noticia);
        }
        public void UpDateNoti(Noticia noticia)
        {
            database.Update(noticia);
        }
        public void DeleteAll()
        {
            database.DeleteAll<Noticia>();
        }
        public void DeleteNoti(Noticia noticia)
        {
            database.Delete(noticia);
        }
        public Noticia GetNoticia(int idnoti)
        {
            return database.Table<Noticia>().FirstOrDefault(c => idnoti == c.IdNoticia);
        }
        public List<Noticia> GetNorticias()
        {
            return database.Table<Noticia>().ToList();
        }
        public void Dispose()
        {
            database.Dispose();
        }
    }
}
