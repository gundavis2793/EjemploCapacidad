using App_Utb.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Utb.Data
{
    public class AppUtbDataBase
    {
        public SQLiteConnection database;
        public AppUtbDataBase(string dbPath)
        {


            database = new SQLiteConnection(dbPath);
            
        }
        public SQLiteConnection GetConection()
        {
            return database;
        }
 
    }
}
