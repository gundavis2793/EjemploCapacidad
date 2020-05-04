using App_Utb.Data;
using App_Utb.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App_Utb.ViewModels
{
    public class MostrarUsuarioViewModel
    {
        public Verificacion_Usuario usuario { get; set; }
        public List<Carreras_Estudiante> carreras { get; set; }
        public MostrarUsuarioViewModel()
        {
            List<Verificacion_Usuario> lista
                = new List<Verificacion_Usuario>();
            UsuarioDatabase database = new UsuarioDatabase(DependencyService
.Get<IFileHelper>()
.GetLocalFilePath("usuariodb.db3"));
            lista = database.GetUsuarios();
            usuario = lista[0];
            CarreraDatabase databasec = new CarreraDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("usuariodb.db3"));
            carreras = databasec.GetCarreras();
        }


    }
}
