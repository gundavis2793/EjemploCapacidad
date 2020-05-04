using App_Utb.Modelos;
using App_Utb.ViewModels;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MostrarNoticia
    {
        private int noticia;
        private DeporteViewmodel list;

        //iniciar La Pagina MostrarNoticia con el contenido del item a de la ListaNoticias implementada en la clase NoticiaViewModel
        public MostrarNoticia(int a, NoticiaViewModel list)
        {
            InitializeComponent();
            Noticia noticia = new Noticia { contenido = list.ListaNoticias[a].contenido, fecha = list.ListaNoticias[a].fecha, titulo = list.ListaNoticias[a].titulo, imagen = list.ListaNoticias[a].imagen, IdNoticia = list.ListaNoticias[a].IdNoticia, imagenIcono = list.ListaNoticias[a].imagenIcono };
  

            this.BindingContext = noticia;


            


        }
       

        public MostrarNoticia(int a, DeporteViewmodel list)
        {
            InitializeComponent();
            Noticia noticia = new Noticia { contenido = list.ListaNoticias[a].contenido, fecha = list.ListaNoticias[a].fecha, titulo = list.ListaNoticias[a].titulo, imagen = list.ListaNoticias[a].imagen, IdNoticia = list.ListaNoticias[a].IdNoticia, imagenIcono = list.ListaNoticias[a].imagenIcono };


            this.BindingContext = noticia;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var mainPage = (Application.Current.MainPage as NavigationPage).CurrentPage;
            (mainPage as MasterDetailPage).IsPresented = true;

        }
        private async void AccesoDirecto(object sender, EventArgs e)
        {
            var pr = new PiePagina();
            var scaleAnimation = new ScaleAnimation
            {
                PositionIn = MoveAnimationOptions.Bottom,
                PositionOut = MoveAnimationOptions.Bottom
            };

            pr.Animation = scaleAnimation;
            await PopupNavigation.PushAsync(pr);

        }


    }
}