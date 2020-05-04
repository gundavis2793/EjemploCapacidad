
using App_Utb.Data;
using App_Utb.Helpers;
using App_Utb.Modelos;
using App_Utb.Views;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagLatUsuario : ContentPage
    {
        IFileHelper usuario = DependencyService.Get<IFileHelper>();
        Verificacion_Usuario UsuarioA { get; set; }
        public PagLatUsuario()
        {
            InitializeComponent();

            string file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Usuario.txt");
            UsuarioDatabase database = new UsuarioDatabase(DependencyService
                     .Get<IFileHelper>()
                     .GetLocalFilePath("usuariodb.db3"));
            List<Verificacion_Usuario> usuarios = new List<Verificacion_Usuario>();
            usuarios = database.GetUsuarios();
            if (usuarios.Count==0)
            {
                Boton_Continuar.IsVisible = false;
            }else
            UsuarioA = usuarios[0];

        }
        public  void Estudiante()
        {
           
        }
        public async void Docente(object sender, EventArgs e)
        {
            bool x = await DisplayAlert("Tipo De Usuario", "Deseas Recibir Notificaciones Para Docentes?", "Si", "No");
            if (x)
            {
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Usuario.txt");
                File.WriteAllText(fileName, "Docente");
                await Navigation.PopToRootAsync();
            }
        }
        public async void Invitado(object sender, EventArgs e)
        {
            bool x = await DisplayAlert("Tipo De Usuario", "Deseas Recibir Notificaciones Para Invitados?", "Si", "No");
            if (x)
            {
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Usuario.txt");
                File.WriteAllText(fileName, "Invitado");
                await Navigation.PopToRootAsync();
            }
        }

        private async void Radio1_Clicked(object sender, EventArgs e)
        {
            bool x = await DisplayAlert("Tipo De Usuario", "Deseas Recibir Notificaciones Para Estudiantes?", "Si", "No");
            if (x)
            {
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Usuario.txt");
                File.WriteAllText(fileName, "Estudiante");
                await Navigation.PopToRootAsync();
            }
        }

        private async void Button_Clicked_Loguear(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaUsuario());
        }
        private async void BotonContinuar(object sender, EventArgs e)
        {
            if (UsuarioA.rol.Equals("acad_estudiante"))
            {
                await Navigation.PushAsync(new MostrarUsuario());
            }else
            await Navigation.PushAsync(new MostrarMaterias());
        }

    }
}