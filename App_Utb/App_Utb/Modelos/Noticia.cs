using SQLite;

namespace App_Utb.Modelos
{
    public class Noticia
    { 
        public int IdNoticia { get; set; }
        public string contenido { get; set; }
        public string fecha { get; set; }
        public string titulo { get; set; }
        public string imagen { get; set; }
        public string imagenIcono { get; set; }


    }

}
