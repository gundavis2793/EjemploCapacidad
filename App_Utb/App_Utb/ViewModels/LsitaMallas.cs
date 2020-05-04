using System;
using System.Collections.Generic;

namespace App_Utb
{
    public class LsitaMallas
    {
        public IList<String> Mallas { get; set; }
        public LsitaMallas(Carrera carrera)
        {
            Mallas = new List<string>();
            Mallas.Add(carrera.mcurricular1);
            if (carrera.mcurricular2.Equals(""))
            {

            }
            else
            {
                Mallas.Add(carrera.mcurricular2);
            }
        }
        public IList<string> GetAll()
        {
            return (Mallas);
        }
    }
}
