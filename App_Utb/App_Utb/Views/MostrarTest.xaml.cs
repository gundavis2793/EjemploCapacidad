
using App_Utb.ViewModels;
using Microcharts;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DataChart = Microcharts.Entry;

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MostrarTest
    {
        public MostrarTest(Resultados Nu)
        {
            InitializeComponent();
            BindingContext = null;

            if (Device.RuntimePlatform != Device.iOS)
                Padding = new Thickness(200);

           // BindingContext = new ViewModel.DisplayChartViewModel();

            ResultadoGraf(Nu);
        }

        public void ResultadoGraf(Resultados Re)
        {
            base.OnAppearing();
            int a1 = Convert.ToInt32(Re.A);
            int b1 = Convert.ToInt32(Re.B);
            int c1 = Convert.ToInt32(Re.C);
            int d1 = Convert.ToInt32(Re.D);
            int e1 = Convert.ToInt32(Re.E);
            int f1 = Convert.ToInt32(Re.F);
            int g1 = Convert.ToInt32(Re.G);
            int h1 = Convert.ToInt32(Re.H);
            List<DataChart> datachartlist = new List<DataChart>
            {
                new DataChart(a1)
                {
                    Color = SkiaSharp.SKColor.Parse("#4186ef"),
                    TextColor = SkiaSharp.SKColor.Parse("#4186ef"),
                    Label = "Ciencas de la Educacion",
                    ValueLabel = a1.ToString()+"%"
                },
                new DataChart(b1)
                {
                    Color = SkiaSharp.SKColor.Parse("#d5cb59"),
                    TextColor = SkiaSharp.SKColor.Parse("#d5cb59"),
                    Label = "Ciencias Economicas Admi.",
                    ValueLabel = b1.ToString()+"%"
                },
                new DataChart(c1)
                {
                    Color = SkiaSharp.SKColor.Parse("#d8d813"),
                    TextColor = SkiaSharp.SKColor.Parse("#d8d813"),
                    Label = "Ciencias de la Salud",
                    ValueLabel = c1.ToString()+"%"
                },
                new DataChart(d1)
                {
                    Color = SkiaSharp.SKColor.Parse("#da6213"),
                    TextColor = SkiaSharp.SKColor.Parse("#da6213"),
                    Label = "Ciencias Sociales",
                    ValueLabel = d1.ToString()+"%"
                },
                new DataChart(e1)
                {
                    Color = SkiaSharp.SKColor.Parse("#50adda"),
                    TextColor = SkiaSharp.SKColor.Parse("#50adda"),
                    Label = "Ciencias Exactas",
                    ValueLabel = e1.ToString()+"%"
                },
                new DataChart(f1)
                {
                    Color = SkiaSharp.SKColor.Parse("#bd3535"),
                    TextColor = SkiaSharp.SKColor.Parse("#bd3535"),
                    Label = "Arte, Arquitectura y Diseño",
                    ValueLabel = f1.ToString()+"%"
                },
                new DataChart(g1)
                {
                    Color = SkiaSharp.SKColor.Parse("#095195"),
                    TextColor = SkiaSharp.SKColor.Parse("#095195"),
                    Label = "Ingenierias",
                    ValueLabel = g1.ToString()+"%"
                },
                new DataChart(h1)
                {
                    Color = SkiaSharp.SKColor.Parse("#00b24f"),
                    TextColor = SkiaSharp.SKColor.Parse("#00b24f"),
                    Label = "Ciencias Biologicas y Agro.",
                    ValueLabel = h1.ToString()+"%"
                },
            };
            Grafica3.Chart = new Microcharts.BarChart
            {
                LabelTextSize = 30,
                LabelOrientation = Orientation.Vertical,
                ValueLabelOrientation = Orientation.Vertical,
                Entries = datachartlist
            };
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
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var mainPage = (Application.Current.MainPage as NavigationPage).CurrentPage;
            (mainPage as MasterDetailPage).IsPresented = true;

        }
    }
}