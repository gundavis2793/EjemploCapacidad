using App_Utb.Modelos;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MallaVenta : PopupPage
    {
        private Carrera carrera;
        private CarreraSanta carrerasanta;

        public MallaVenta(int carrera)
        {
            InitializeComponent();

        }
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var mainPage = (Application.Current.MainPage as NavigationPage).CurrentPage;
            (mainPage as MasterDetailPage).IsPresented = true;

        }

        public MallaVenta(CarreraSanta carrerasanta)
        {
            InitializeComponent();
            this.BindingContext = carrerasanta;
        }
        public MallaVenta(Carrera carrera)
        {
            InitializeComponent();
            this.BindingContext = carrera;
        }
        protected override bool OnBackButtonPressed()
        {
            PopupNavigation.RemovePageAsync(this);
            return base.OnBackButtonPressed();

        }

        public ScaleAnimation Animation { get; internal set; }


    }
}