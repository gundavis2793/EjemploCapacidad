using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_Utb.Data;
using App_Utb.Modelos;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MostrarListaEstudiantes : MasterDetailPage
    {
        public List<Materias_Docente> listaMatDocente { get; set; }
        public int index { get; set; }
        public MostrarListaEstudiantes(List<Materias_Docente> listaMateriassDocente, ItemTappedEventArgs e)
        {
            InitializeComponent();

        }
        public MostrarListaEstudiantes(int cod)
        {
            InitializeComponent();
            ListaEstudiantesDataBase database = new ListaEstudiantesDataBase(DependencyService
                    .Get<IFileHelper>()
                    .GetLocalFilePath("usuariodb.db3"));
            var ele = database.GetItemsNotDoneAsync(cod);
            int var = 0;
            for (int i = 0; i < ele.Count; i++)
            {
                var++;
                ele[i].validado = var + "";
            }
            this.BindingContext = ele;

        }
        protected override async void OnAppearing()
        {

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
    }
}