
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using App_Utb.Views;
using System.IO;
using App_Utb.Data;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Extensions;

namespace App_Utb
{

    public partial class MainPage
    {
        //instancia pagina cargarDatos
        public PopupPage pr { get; set; }
        //CODIGO DE CAROUSEL
        public string FileUsu;

        public MainPage(bool shallNavigate)
        {
            InitializeComponent();
            string usuario = "";
            FileUsu = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Usuario.txt");
            UsuarioDatabase database = new UsuarioDatabase(DependencyService
                              .Get<IFileHelper>()
                              .GetLocalFilePath("usuariodb.db3"));
            var usu = database.GetUsuarios();

            this.BindingContext = usuario;
            //CODIGO CAROUSEL
            List<string> students = new List<string>()
                {
                    "Carousel1.jpg",
                    "Carousel2.jpg",
                    "Carousel3.jpg",
                };

            listViewCarousal.ItemsSource = students;

            Device.StartTimer(TimeSpan.FromSeconds(4), (Func<bool>)(() =>
            {

                int currentIndex = listViewCarousal.Position;
                int nextIndex = currentIndex < listViewCarousal.ItemsSource.OfType<object>().Count() - 1
                                       ? currentIndex + 1
                                       : 0;
                listViewCarousal.Position = nextIndex;

                return true;
            }));

            if (shallNavigate == true)
            {
                IniciarNotificaciones();
            }
        }
        public async void CargarDatos()
        {
            pr = new PaginaCargando();
            var scaleAnimation = new ScaleAnimation
            {
                PositionIn = MoveAnimationOptions.Bottom,
                PositionOut = MoveAnimationOptions.Bottom
            };
            pr.Animation = scaleAnimation;
            await PopupNavigation.PushAsync(pr);
        }

        public async void Principal()
        {
            //var cargar = new PaginaCargando();
            //Navigation.PushAsync(new MainPage(false));
            await Navigation.PopToRootAsync();
            await Navigation.RemovePopupPageAsync(pr);
        }
        public void IniciarNotificaciones()
        {
            Navigation.PushAsync(new PaginaNotificaciones());
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

        //NAVEGACIONES DE ICONOS 

        private void IniciarNoticia(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaNoticia());
        }

        private void IniciarCarrera(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaCarreras2());
        }

        private void IniciarTalleres(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaTalleres());
        }

        private void IniciarUbicacion(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaUbicacion());
        }

        private void IniciarDeportes(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaDeportes());
        }

        private void IniciarPosgrado(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaPosgrado());
        }

        private void IniciarTest(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaTest());
        }

        private void IniciarMultimedia(object sender, EventArgs e)
        {

            Navigation.PushAsync(new PaginaMultimedia());

        }

        private void IniciarDeudas(object sender, EventArgs e)
        {

            Navigation.PushAsync(new PaginaDeudas());

        }
        private void IniciarSistema(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaSistema());
        }

        private void IniciarInicio(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void IniciarCalendario(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaTalleres());
        }
        private void IniciarRegistro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaRegistro());
        }
        private void IniciarMaterias(object sender, EventArgs e)
        {
            if (File.ReadAllText(FileUsu).Equals("Docente"))
            {
                Navigation.PushAsync(new MostrarMaterias());
            }
            else
            {
                Navigation.PushAsync(new PaginaCarreraEstudiante());
            }

        }
        private void IniciarNotificacion(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaNotificaciones());
        }
        //iniciar Menu
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var mainPage = (Application.Current.MainPage as NavigationPage).CurrentPage;
            (mainPage as MasterDetailPage).IsPresented = true;

        }


    }
}
