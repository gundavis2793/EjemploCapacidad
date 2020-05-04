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
    public partial class PaginaDeportes
    {
        DeporteViewmodel list = new DeporteViewmodel("");
        public PaginaDeportes()
        {
            InitializeComponent();
            this.BindingContext = new DeporteViewmodel();
        }
        private void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        { }
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var mainPage = (Application.Current.MainPage as NavigationPage).CurrentPage;
            (mainPage as MasterDetailPage).IsPresented = true;

        }
        private void Carrera(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MostrarCarrera());
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

        private void Lista_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            var pagina = new Page();

            var c = sender.GetHashCode();
            int noticia = e.ItemIndex;
            pagina = new MostrarNoticia(noticia,list);
            Navigation.PushAsync(pagina);


        }

    }
}