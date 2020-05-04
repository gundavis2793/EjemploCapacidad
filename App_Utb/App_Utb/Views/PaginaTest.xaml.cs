using App_Utb.Views;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaTest
    {

        public PaginaTest()
        {
            InitializeComponent();
        }

        private void ButtonIniciarTest(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IniciarTest());
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