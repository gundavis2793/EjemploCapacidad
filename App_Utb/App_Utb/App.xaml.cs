using App_Utb.Data;
using App_Utb.Helpers;
using App_Utb.Modelos;
using App_Utb.Themes;
using App_Utb.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Utb
{
    public partial class App : Application
    {
        ActivityIndicator act = new ActivityIndicator();
        
        IFileHelper usuario = DependencyService.Get<IFileHelper>();
        public static string FilePath;
        public static string FileUsu;
        private bool aux ;

        public App()
        {
            InitializeComponent();
            act.IsRunning = true;
            NavigationPage Nav = new NavigationPage(new MainPage(aux));
            MainPage = Nav;
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Tema.txt");
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (File.Exists(fileName))
            {

                string theme = File.ReadAllText(fileName);
                switch (theme)
                {
                    case ("Original"):
                        mergedDictionaries.Add(new Original());
                        break;
                    case ("Claro"):
                        mergedDictionaries.Add(new Claro());
                        break;
                    case ("Oscuro"):
                    default:
                        mergedDictionaries.Add(new Oscuro());
                        break;
                }
            }
            ICollection<ResourceDictionary> mergedDictionaries1 = Application.Current.Resources.MergedDictionaries;
            mergedDictionaries1.Add(new Invitado());

        }

        public App(string filePath, bool shallNavigate)
        {

            InitializeComponent();
            if (shallNavigate)
            {
                MainPage = new NavigationPage(new MainPage(shallNavigate));
                //MainPage = new NavigationPage(new MainPage(new NavigationPage(new PaginaNotificaciones())));
            }
            else
            {
                MainPage = new NavigationPage(new MainPage(shallNavigate));
            }
            //NavigationPage Nav = new NavigationPage(new MainPage());
            //MainPage = Nav;
            FilePath = filePath;
            ICollection<ResourceDictionary> mergedDictionaries1 = Application.Current.Resources.MergedDictionaries;
            mergedDictionaries1.Add(new Invitado());
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Tema.txt");
            FileUsu = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Usuario.txt");
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (File.Exists(fileName))
            {
                string theme = File.ReadAllText(fileName);
                switch (theme)
                {
                    case ("Original"):
                        mergedDictionaries.Add(new Original());
                        break;
                    case ("Claro"):
                        mergedDictionaries.Add(new Claro());
                        break;
                    case ("Oscuro"):
                    default:
                        mergedDictionaries.Add(new Oscuro());
                        break;
                }
            }
            if (File.Exists(FileUsu))
            {
                string theme = File.ReadAllText(FileUsu);
                switch (theme)
                {
                    case ("Docente"):
                        mergedDictionaries1.Add(new Docente());
                        break;
                    case ("Estudiante"):
                        mergedDictionaries.Add(new EstudianteStyle());
                        break;
                    case ("Invitado"):
                    default:
                        mergedDictionaries.Add(new Invitado());
                        break;
                }
            }

            CargarDatos();
        }
        public async void CargarDatos()
        {
            //var cargar = new MainPage(false);

            if (NetWorkCheck.IsInternet())
            {
                //cargar.CargarDatos();
                ListaNoticias Lista1 = new ListaNoticias();
                ListaDeportes Lista2 = new ListaDeportes();

                if (Lista1.Noticias.Count != 0 && Lista2.Deportes.Count != 0)
                {

                }
                else
                {
                    Lista1.GetJSON();

                    Lista2.GetJSON();
                    // var firebase = new FirebaseHelper();
                    
                }
              //  cargar.Principal();
            }

        }
        //public async void CargarDatos()
        //{

        //    if (NetWorkCheck.IsInternet())
        //    {
        //        //
        //        var firebase = new FirebaseHelper();
        //        var notificaciones = await firebase.GetAllNotificaciones();
        //        using (SQLiteConnection conn = new SQLiteConnection(FilePath))
        //        {

        //            conn.CreateTable<Notificacion>();
        //            conn.DeleteAll<Notificacion>();
        //            conn.InsertAll(notificaciones);

        //        }
        //        //
        //        ListaNoticias Lista1 = new ListaNoticias();
        //        ListaDeportes Lista2 = new ListaDeportes();

        //        if (Lista1.Noticias.Count != 0 && Lista2.Deportes.Count != 0)
        //        {

        //        }
        //        else
        //        {
        //            Lista1.GetJSON();

        //            Lista2.GetJSON();
        //           // var firebase = new FirebaseHelper();
        //            await firebase.GetAllNotificaciones();
        //        }
        //    }
        //}

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnSleep()
        {
            base.OnSleep();
        }

        protected override void OnResume()
        {
            base.OnResume();
        }
    }
}
