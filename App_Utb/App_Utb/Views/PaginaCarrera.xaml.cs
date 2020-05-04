using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaCarrera
    {
        
        public PaginaCarrera()
        {
            InitializeComponent();
            
            this.BindingContext = new CarreraViewModels();          
        }


        private void Carrera(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MostrarCarrera());
        }

        public string datos { get; set; }

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

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var mainPage = (Application.Current.MainPage as NavigationPage).CurrentPage;
            (mainPage as MasterDetailPage).IsPresented = true;
            
        }
        private void ListaCarreras_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
             
        }

        private void ListaCarreras_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var pagina = new Page();
            
            var c = sender.GetHashCode();
            int carrera = e.ItemIndex;
            pagina = new MostrarCarrera(carrera);
            Navigation.PushAsync(pagina);
        }
    }
}