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
using App_Utb.ViewModels;

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaCarreraSanta 
    {
        public PaginaCarreraSanta()
        {
            InitializeComponent();
            this.BindingContext = new CarreraViewModelsSanta();
        }
        private void Carrera(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MostrarCarreraSanta());
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

        private void ListaCarreras_ItemTappedSanta(object sender, ItemTappedEventArgs e)
        {
            var pagina = new Page();

            var c = sender.GetHashCode();
            int carrera = e.ItemIndex;
            pagina = new MostrarCarreraSanta(carrera);
            Navigation.PushAsync(pagina);
        }
    }
}