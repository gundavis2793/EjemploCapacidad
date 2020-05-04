using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using App_Utb.Views;

namespace App_Utb
{

    public partial class PiePagina : PopupPage

    {
        public PiePagina()
        {
            InitializeComponent();
        }

        private void AbrirMenu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage(false));
            Navigation.PopToRootAsync();
            Navigation.RemovePopupPageAsync(this);


        }
        private void AbrirCalendario(object sender, EventArgs e)
        {
            Navigation.RemovePopupPageAsync(this);
            Navigation.PushAsync(new PaginaCalendario());


        }
        private void AbrirUbicacion(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaUbicacion());
            Navigation.RemovePopupPageAsync(this);


        }
    }
}