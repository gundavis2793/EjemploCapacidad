using App_Utb.Behaviors;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace App_Utb.Views
{
    [DesignTimeVisible(true)]
    public partial class PaginaUbicacion : TabbedPage
    {
        public PaginaUbicacion()
        {
            InitializeComponent();

            MapElAto.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(-16.4958189, -68.1890588), Distance.FromMiles(0.3)));
            MapLaPaz.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(-16.5060885, -68.1299812), Distance.FromMiles(0.5)));
            MapSantaCruz.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(-17.7704825, -63.1777653), Distance.FromMiles(0.3)));
            AddPins();

        }

        private void AddPins()
        {

            var pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-16.4958189, -68.1890588),
                Label = "Universidad Tecnologica Boliviana",
                Address = "Los Andes"
            };


            MapElAto.Pins.Add(pin);
            var pin1 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-16.5006571, -68.1342995),
                Label = "Universidad Tecnologica Boliviana",
                Address = "Calle Colombia",

            };
            MapLaPaz.Pins.Add(pin1);
            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-16.5060885, -68.1299812),
                Label = "Universidad Tecnologica Boliviana",
                Address = "Unidad Academica"

            };

            MapLaPaz.Pins.Add(pin4);
            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-16.5112241, -68.1243338),
                Label = "Universidad Tecnologica Boliviana",
                Address = "UTB - Postgrado",

            };
            MapLaPaz.Pins.Add(pin5);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-17.7704825, -63.1777653),
                Label = "Universidad Tecnologica Boliviana",
                Address = "Santa Cruz"
            };

            MapSantaCruz.Pins.Add(pin2);
        }


        private void Street_OnClicked(object sender, EventArgs e)
        {
            MapLaPaz.MapType = MapType.Street;

        }


        private void Hybrid_OnClicked(object sender, EventArgs e)
        {
            MapLaPaz.MapType = MapType.Hybrid;

        }

        private void Satellite_OnClicked(object sender, EventArgs e)
        {
            MapLaPaz.MapType = MapType.Satellite;

        }
        private void Street_OnClicked1(object sender, EventArgs e)
        {

            MapElAto.MapType = MapType.Street;

        }


        private void Hybrid_OnClicked1(object sender, EventArgs e)
        {

            MapElAto.MapType = MapType.Hybrid;

        }

        private void Satellite_OnClicked1(object sender, EventArgs e)
        {

            MapElAto.MapType = MapType.Satellite;

        }
        private void Street_OnClicked2(object sender, EventArgs e)
        {

            MapSantaCruz.MapType = MapType.Street;
        }


        private void Hybrid_OnClicked2(object sender, EventArgs e)
        {

            MapSantaCruz.MapType = MapType.Hybrid;
        }

        private void Satellite_OnClicked2(object sender, EventArgs e)
        {

            MapSantaCruz.MapType = MapType.Satellite;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

        }

    }
}