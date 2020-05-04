using System;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaCarreras2
    {
        public PaginaCarreras2()
        {
            InitializeComponent();
        }
        private void PaginaCarreraLaPaz(object sender, EventArgs e)
        {
            // string lista = "ListaCarreras";
            Navigation.PushAsync(new PaginaCarrera());
        }
        private void PaginaCarreraSanta(object sender, EventArgs e)
        {
            //string lista = "ListaCarrerasSanta";
            Navigation.PushAsync(new PaginaCarreraSanta());
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