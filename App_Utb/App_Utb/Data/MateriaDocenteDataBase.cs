using App_Utb.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Utb.Data
{
    class MateriaDocenteDataBase
    {

            
            public SQLiteConnection database;
            public MateriaDocenteDataBase(string dbPath)
            {


                database = new SQLiteConnection(dbPath);
                database.CreateTable<Materias_Docente>();
            }
            public void InsertMateria(Materias_Docente usuario)
            {
                database.Insert(usuario);
            }
            public void UpDateMateria(Materias_Docente usuario)
            {
                database.Update(usuario);
            }
            public void DeleteAll()
            {
                database.DeleteAll<Materias_Docente>();
            }
            public void DeleteMateria(Materias_Estudiante usuario)
            {
                database.Delete(usuario);
            }

            public List<Materias_Docente> GetMaterias()
            {
                return database.Table<Materias_Docente>().ToList();
            }
            public void Dispose()
            {
                database.Dispose();
            }
        }
    
}
