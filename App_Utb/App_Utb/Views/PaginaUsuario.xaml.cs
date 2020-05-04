using App_Utb.Data;
using App_Utb.Helpers;
using App_Utb.Modelos;
using App_Utb.Themes;
using App_Utb.ViewModels;
using App_Utb.Views;
using Plugin.Connectivity;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaUsuario : ContentPage
    {
        IFileHelper IfileHelper;
        public string nomusu { get; set; }
        UsuarioViewModel usu;
       
        public PaginaUsuario()
        {

            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            if (NetWorkCheck.IsInternet())
            {
                base.OnAppearing();
            }
            else
            {
                await DisplayAlert("Sin Conexion", "Se necesita conexion a internet ", "Entendido");
                await Navigation.PopAsync();
            }


        }

        private async void Iniciar_Sesion_Clicked(object sender, EventArgs e)
        {
            usu = new UsuarioViewModel();
            if (contrasenaEntry.Text != null && correoEntry.Text != null)
            {
                ICollection<ResourceDictionary> mergedDictionaries1 = Application.Current.Resources.MergedDictionaries;
                string _contrasena = contrasenaEntry.Text.ToString();
                string _correo = correoEntry.Text.ToString();
                
                await usu.CargarUsuario(_correo, _contrasena);

                if (true)
                {

                    List<Verificacion_Usuario> listUsu = new List<Verificacion_Usuario>();
                    listUsu = usu.UsuarioData.GetUsuarios();
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic("Invitado");
                    if (listUsu[0].rol.Equals("acad_estudiante"))
                    {
                        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Usuario.txt");
                        File.WriteAllText(fileName, "Estudiante");
                        mergedDictionaries1.Add(new EstudianteStyle());
                    }
                    else
                    {
                        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Usuario.txt");
                        File.WriteAllText(fileName, "Docente");
                        mergedDictionaries1.Add(new Docente());
                    }
                    var mainPage = (Application.Current.MainPage as NavigationPage).RootPage;
                    (mainPage as MasterDetailPage).Master = new Menu();
                    await Navigation.PopToRootAsync();
                    //activityIndicator.IsRunning = false;
                    await DisplayAlert("Bienvenido", "Ahora tienes mas opciones en tu menu de inicio", "Ok");

                }
                else
                {
                    await DisplayAlert("Ok", "introduzca datos correctos", "Ok");
                }

            }
            else
            {
                await DisplayAlert("Error", "Por Favor Llene todos los Campos", "OK");
            }


        }


    }


}