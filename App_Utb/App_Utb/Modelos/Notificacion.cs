using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;
using Firebase.Database.Query;
namespace App_Utb.Modelos
{
    public class Notificacion
    {
        [PrimaryKey, AutoIncrement]
        public int IdNotificacion { get; set; }
        public string segmentacion { get; set; }
        public string titulo { get; set; }
        public string mensaje { get; set; }
        public int  grado { get; set; }
        public string  fecha { get; set; }
        public string emoticon { get; set; }

        public Notificacion() { }
        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}{4}{5}", IdNotificacion, titulo, mensaje,grado,fecha,emoticon);
        }
        public Notificacion(string titul, string mensaj)
        {
            IdNotificacion = 0;
            titulo = titul;
            mensaje = mensaj;
            grado = 3;
            segmentacion = "Invitado";
            fecha = "10/10/2010";
            emoticon = "&#128240;";

        }
        public void setEmoticon()
        {
            if (grado==3)
            {
                emoticon = "&#128308;";
            }
            else if (grado==2)
            {
                emoticon = "&#128309;";
            }
            else if (grado==1)
            {
                emoticon = "&#9898;";
            }
            else
            {
                emoticon= "&#9898;";
            }
        }
    }
}
