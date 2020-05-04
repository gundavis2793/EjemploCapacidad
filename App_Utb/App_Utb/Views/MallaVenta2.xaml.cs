using App_Utb.Modelos;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MallaVenta2 : PopupPage
    {
        private Carrera carrera;
        private CarreraSanta carrerasanta;

        public MallaVenta2(int carrera)
        {
            InitializeComponent();

        }
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var mainPage = (Application.Current.MainPage as NavigationPage).CurrentPage;
            (mainPage as MasterDetailPage).IsPresented = true;

        }
        public MallaVenta2(CarreraSanta carrerasata)
        {
            InitializeComponent();
            this.BindingContext = carrerasanta;
        }
        public MallaVenta2(Carrera carrera)
        {
            InitializeComponent();
            this.BindingContext = carrera;
        }

        public ScaleAnimation Animation { get; internal set; }


    }
}