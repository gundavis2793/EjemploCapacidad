using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms.PinchZoomImage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MostrarCarrera
    {
        private Carrera carrera { get; set; }

        public MostrarCarrera()
        {
            InitializeComponent();

        }
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var mainPage = (Application.Current.MainPage as NavigationPage).CurrentPage;
            (mainPage as MasterDetailPage).IsPresented = true;

        }

        public MostrarCarrera(int a)
        {
            InitializeComponent();
            var carr = new CarreraViewModels();
            carrera = carr.SeleccionarCarrera(a);
            this.BindingContext = carrera;
        }

        [Obsolete]
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

        //botones de carreras...........14

        //DESCRIPCION DE LA CARRERA
        private void DescripcionVentas(object sender, EventArgs e)
        {
            Descripcion.IsVisible = true;
            SubirText.IsVisible = true;
            if (Descripcion.MaxLines == 50)
            {
                Descripcion.MaxLines = 0;
                Descripcion.IsVisible = false;
                SubirText.IsVisible = false;
            }
            else
                Descripcion.MaxLines = 50;
        }

        private void SubirDescripcion(object sender, EventArgs e)
        {
            if (Descripcion.MaxLines == 50)
            {
                Descripcion.MaxLines = 0;
                Descripcion.IsVisible = false;
                SubirText.IsVisible = false;
            }
            else
                Descripcion.MaxLines = 50;
        }

        //PERFIL PROFECIONAL 

        private void PerfilVentas(object sender, EventArgs e)
        {
            Perfil.IsVisible = true;
            SubirText2.IsVisible = true;
            if (Perfil.MaxLines == 50)
            {
                Perfil.MaxLines = 0;
                SubirText2.IsVisible = false;
                Perfil.IsVisible = false;
            }
            else
                Perfil.MaxLines = 50;
        }

        private void SubirPerfil(object sender, EventArgs e)
        { 
            if (Perfil.MaxLines == 50)
            {
                Perfil.MaxLines = 0;
                SubirText2.IsVisible = false;
                Perfil.IsVisible = false;
            }
            else
                Perfil.MaxLines = 50;
        }

        //CAMPO LABORAL 

        private void CampoVentas(object sender, EventArgs e)
        {
            Campo.IsVisible = true;
            SubirText3.IsVisible = true;
            if (Campo.MaxLines == 50)
            {
                Campo.MaxLines = 0;
                Campo.IsVisible = false;
                SubirText3.IsVisible = false;
            }
            else
                Campo.MaxLines = 50;
        }
        private void SubirCampo(object sender, EventArgs e)
        {
            if (Campo.MaxLines == 50)
            {
                Campo.MaxLines = 0;
                Campo.IsVisible = false;
                SubirText3.IsVisible = false;
            }
            else
                Campo.MaxLines = 50;
        }

        //TITULACION

        private void TitulacionVentas(object sender, EventArgs e)
        {
            Titulacion.IsVisible = true;
            if (Titulacion.MaxLines == 50)
            {
                Titulacion.MaxLines = 0;
                Titulacion.IsVisible = false;
            }
            else
                Titulacion.MaxLines = 50;
        }

        //MALLA CURRICULAR 

        private async void MallaVentas(object sender, EventArgs e)
        {

            if (malla1.IsVisible == false && malla2.IsVisible == false)
            {
                if (!carrera.malla2.Equals(" "))
                {
                    malla2.IsVisible = true;
                }
                malla1.IsVisible = true;

                Mallas.IsVisible = true;
                Mallas.IsEnabled = true;
                await scrol.ScrollToAsync(Mallas, ScrollToPosition.End, true);

            }
            else
            {
                malla1.IsVisible = false;
                malla2.IsVisible = false;
            }
        }

        [Obsolete]
        private async void MallaImagene1(object sender, EventArgs e)
        {
            
            var prr = new MallaVenta(carrera);
            var scaleAnimation = new ScaleAnimation
            {
                PositionIn = MoveAnimationOptions.Bottom,
                PositionOut = MoveAnimationOptions.Bottom
            };

            prr.Animation = scaleAnimation;
            await PopupNavigation.PushAsync(prr);
        }

        [Obsolete]
        private async void MallaImagene2(object sender, EventArgs e)
        {
            var pr = new MallaVenta2(carrera);
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