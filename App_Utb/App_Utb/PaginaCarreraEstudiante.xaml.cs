using App_Utb.Data;
using App_Utb.Modelos;
using App_Utb.Views;
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

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaCarreraEstudiante 
    {
        public List<Carreras_Estudiante> lista { get; set; }
        public PaginaCarreraEstudiante()
        {
            InitializeComponent();
            CarreraDatabase data = new CarreraDatabase(DependencyService
                              .Get<IFileHelper>()
                              .GetLocalFilePath("usuariodb.db3"));
            lista = new List<Carreras_Estudiante>();
            lista = data.GetCarreras();
            this.BindingContext = lista;
        }
        private void ListaCarrerasssss_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var pagina = new Page();
            var c = sender.GetType();
            int car = e.ItemIndex;
            ;
            pagina = new MostrarMaterias(lista.ElementAt(car).nombre_carrera);
            Navigation.PushAsync(pagina);
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
    }
}