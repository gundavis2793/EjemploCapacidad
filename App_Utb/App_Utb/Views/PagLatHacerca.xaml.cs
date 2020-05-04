using App_Utb.Views;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagLatHacerca : ContentPage
    {
        private int aux = 0;
        public PagLatHacerca()
        {
            InitializeComponent();
        }

        private void Llamar(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open("22180808");
            }
            catch (ArgumentNullException anEx)
            {
                // Number was null or white space
            }
            catch (FeatureNotSupportedException ex)
            {
                // Phone Dialer is not supported on this device.
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }
        private async void imagen_Clicked(object sender, EventArgs e)
        {
            aux++;
            if (aux == 8)
            {
                var prr = new Desarrolladores();
                var scaleAnimation = new ScaleAnimation
                {
                    PositionIn = MoveAnimationOptions.Bottom,
                    PositionOut = MoveAnimationOptions.Bottom
                };
                prr.Animation = scaleAnimation;
                await PopupNavigation.PushAsync(prr);
            }
        }
    }

}