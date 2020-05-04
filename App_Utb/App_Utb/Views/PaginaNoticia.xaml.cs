using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaNoticia
    {
        NoticiaViewModel list = new NoticiaViewModel("");
        public PaginaNoticia()
        {
            InitializeComponent();

            this.BindingContext = list;
        }

        private void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        { }
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

        private void Lista_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            var pagina = new Page();

            var c = sender.GetHashCode();
            int noticia = e.ItemIndex;
            pagina = new MostrarNoticia(noticia,list);
            Navigation.PushAsync(pagina);


        }

        //codigo pagina animacion





    }
}