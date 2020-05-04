using App_Utb.Data;
using App_Utb.Modelos;
using App_Utb.ViewModels;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Utb.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MostrarMaterias : MasterDetailPage
    {
        int cod = 1;
        public ImageSource ImagenSourse { get; set; }
        public List<Materias_Docente> ListaMateriassDocente { get; set; }
        public List<Materias_Estudiante> ListaMateriass { get; set; }
        public int ind { get; set; }
        public Verificacion_Usuario Usuario { get; private set; }
        public List<Horarios_Aula_Estudiante> Horarios { get; set; }
        List<Verificacion_Usuario> usu = new List<Verificacion_Usuario>();
        public MostrarMaterias(string index)
        {
            InitializeComponent();
            MateriaDataBase database = new MateriaDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("usuariodb.db3"));
            List<Materias_Estudiante> mat = database.ListaporCarrera(index);
            ListaMateriass = mat;
            UsuarioDatabase database1 = new UsuarioDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("usuariodb.db3"));
            usu = database1.GetUsuarios();

            Usuario = usu[0];
        }

        public MostrarMaterias()
        {
            InitializeComponent();
            MateriaDocenteDataBase database = new MateriaDocenteDataBase(DependencyService
.Get<IFileHelper>()
.GetLocalFilePath("usuariodb.db3"));
            UsuarioDatabase database1 = new UsuarioDatabase(DependencyService
.Get<IFileHelper>()
.GetLocalFilePath("usuariodb.db3"));
            usu = database1.GetUsuarios();


            ListaMateriassDocente = database.GetMaterias();
            usu = database1.GetUsuarios();
            Usuario = usu[0];
            ind = 0;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (Usuario.rol.Equals("acad_estudiante"))
            {
                this.BindingContext = ListaMateriass;
                if (ListaMateriass.Count>0)
                {
                    NombreCar.Text = ListaMateriass[0].nombre_carrera;
                }
                else
                {
                    NombreCar.Text = "SIN MATERIAS INSCRITAS";
                }
            }
            else
            {
                if (ListaMateriassDocente.Count!=0)
                {

                    NombreCar.Text = ListaMateriassDocente[0].nombre_carrera;
                }else
                NombreCar.Text = "SIN MATERIAS ASIGNADAS";
                this.BindingContext = ListaMateriassDocente;

            }


        }
  

        private async void ListaMaterias_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (Usuario.rol.Equals("acad_estudiante"))
            {
                HorarioDataBase dataBase = new HorarioDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("usuariodb.db3"));
                Horarios = dataBase.ListaporMateria(ListaMateriass[e.ItemIndex].id_asigdoc);
                var pagina = new MostrarNotas(e.ItemIndex, ListaMateriass, Horarios);
                var scaleAnimation = new ScaleAnimation
                {
                    PositionIn = MoveAnimationOptions.Right,
                    PositionOut = MoveAnimationOptions.Left
                };

                pagina.Animation = scaleAnimation;
                await PopupNavigation.PushAsync(pagina);

            }
            else
            {
                MateriaDocenteDataBase dataBase = new MateriaDocenteDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("usuariodb.db3"));
                List<Materias_Docente> matdoc = dataBase.GetMaterias();
                cod = matdoc[e.ItemIndex].id_materia_habilitada;
                await Navigation.PushAsync(new MostrarListaEstudiantes(matdoc[e.ItemIndex].id_materia_habilitada));
            }


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