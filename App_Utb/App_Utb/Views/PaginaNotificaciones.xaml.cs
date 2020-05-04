
using App_Utb.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Linq;
using System.Collections.Generic;
using App_Utb.Helpers;
using System.Threading.Tasks;
using Plugin.Connectivity;
using static System.Console;
using System;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
using System.Xml.Linq;
using System.Collections.ObjectModel;

namespace App_Utb.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaNotificaciones : ContentPage
    {
        //variable de tipo firebasehalper que contiene metodos para la conexion y obtencion de datos de firebase
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public static ObservableCollection<Notificacion> items { get; set; }
        public List<Notificacion> cont = new List<Notificacion>();
        public SQLiteConnection conn = new SQLiteConnection(App.FilePath);
        public PaginaNotificaciones()
        {

            items = new ObservableCollection<Notificacion>();

            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {

                conn.CreateTable<Notificacion>();
                cont = conn.Table<Notificacion>().ToList();
            }

            InitializeComponent();
        }


        protected async override void OnAppearing()
        {

            for (int i = 0; i < cont.Count; i++)
            {
                cont[i].setEmoticon();
                items.Add(cont[i]);
            }
            items.Reverse<Notificacion>();
            BindingContext = items;
            base.OnAppearing();
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

        async void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            await DisplayAlert(items[e.SelectedItemIndex].titulo, items[e.SelectedItemIndex].mensaje, "Ok");
        }

        void OnRefresh(object sender, EventArgs e)
        {
            var list = (ListView)sender;
            //put your refreshing logic here
            var itemList = items.Reverse().ToList();
            items.Clear();
            foreach (var s in itemList)
            {
                items.Add(s);
            }
            //make sure to end the refresh state
            list.IsRefreshing = false;
        }

        async void OnTap(object sender, ItemTappedEventArgs e)
        {
            await DisplayAlert(items[e.ItemIndex].titulo, items[e.ItemIndex].mensaje, "Ok");
        }

        void OnMore(object sender, EventArgs e)
        {
            var item = (Xamarin.Forms.MenuItem)sender;
            DisplayAlert("More Context Action", item.CommandParameter + " more context action", "OK");
        }

        void OnDelete(object sender, EventArgs e)
        {
            var item = (Xamarin.Forms.MenuItem)sender;
            items.RemoveAt(0);
        }
    }
}