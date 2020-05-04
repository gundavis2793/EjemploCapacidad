using App_Utb.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_Utb.ViewModels
{
    public class DeporteViewmodel : ListaDeportes
    {
        public List<Noticia> ListaNoticias { get; set; }
        public Noticia Noticia { get; set; }
        //constructor NoticiasViewModel instanciando la Lista ListaNoticias que contiene los elementos del binding 
        public DeporteViewmodel()
        {

            ListaNoticias = GetAll().ToList();
        }
        public DeporteViewmodel(string ele)
        {
            ListaNoticias = GetAll().ToList();
        }
        //metodo que retorna el item i de la ListaNoticias que se inicializa en el comstructor ListaNoticias
        public Noticia SeleccionarNoticia(int i)
        {

            ListaNoticias = GetAll().ToList();

            Noticia noticia = new Noticia { contenido = ListaNoticias[i].contenido, fecha = ListaNoticias[i].fecha, titulo = ListaNoticias[i].titulo, imagen = ListaNoticias[i].imagen, IdNoticia = ListaNoticias[i].IdNoticia, imagenIcono = ListaNoticias[i].imagenIcono };
            Noticia = noticia;

            return Noticia;
        }
    }
}
