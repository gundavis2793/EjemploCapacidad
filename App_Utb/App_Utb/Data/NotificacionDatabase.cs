using App_Utb.Modelos;
using App_Utb.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Utb.Data
{
    public class NotificacionDatabase
    {
        public SQLiteConnection database;
        public NotificacionDatabase(string dbPath)
        {
            

            database = new SQLiteConnection(dbPath);
            database.CreateTable<Notificacion>();
        }
        public void InsertNoti(Notificacion notificacion)
        {
            database.Insert(notificacion);
        }
        public  void UpDateNoti(Notificacion notificacion)
        {
            database.Update(notificacion);
        }
        public void DeleteNoti(Notificacion notificacion)
        {
            database.Delete(notificacion);
        }
        public Notificacion GetNotificacion(int idnoti)
        {
            return database.Table<Notificacion>().FirstOrDefault(c => idnoti == c.IdNotificacion);
        }
        public List<Notificacion> GetNortificaciones()
        {
            return database.Table<Notificacion>().ToList();
        }
        public void Dispose()
        {
            database.Dispose();
        }
    }
}
