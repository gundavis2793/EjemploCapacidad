using System.Collections.Generic;
using System.Linq;

namespace App_Utb
{
    class MallaviewModel
    {

        public List<string> Mallas { get; set; }

        public MallaviewModel(Carrera c)
        {
            LsitaMallas lista
                = new LsitaMallas(c);
            Mallas = lista.GetAll().ToList();
        }


    }
}
