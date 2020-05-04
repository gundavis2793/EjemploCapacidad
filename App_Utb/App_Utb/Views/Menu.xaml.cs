using App_Utb.Data;
using App_Utb.Helpers;
using App_Utb.Modelos;
using App_Utb.Themes;
using App_Utb.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms.Xaml;


namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        UsuarioDatabase database1 = new UsuarioDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("usuariodb.db3"));


        //  private object dir;
        string path { get; set; }
        public Verificacion_Usuario Usuario { get; set; }
        public Menu()
        {
            InitializeComponent();
            IconoCerrar.IsVisible = false;
            BotonCerrar.IsVisible = false;

            
            if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Usuario.txt")))
            {

                if (!File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Usuario.txt")).Equals("Invitado"))
                {
                    var usu = database1.GetUsuarios(); Usuario = usu[0];
                    string nombre = usu[0].nombre + " " + usu[0].ap_paterno + " " + usu[0].ap_materno;
                    labelnombre.IsVisible = true;
                    labelnombre.Text = nombre;
                    labelnombre.FontSize = 12;
                    LabelInicio.Text = "Cerrar Sesión";
                    LabelInicio.FontAttributes = FontAttributes.Bold;
                    LabelInicio.FontSize = 14;
                    BotonCerrar.IsVisible = false;
                    IconoCerrar.IsVisible = false;
                    string base64Image = usu[0].avatar;
                    byte[] Base64Stream = Convert.FromBase64String(base64Image);
                    Img.Source = ImageSource.FromStream(() => new MemoryStream(Base64Stream));
                }
                else
                {
                    labelnombre.IsVisible = false;
                    LabelInicio.Text = "Iniciar Sesión";
                    BotonCerrar.IsVisible = false;
                    IconoCerrar.IsVisible = false;
                }
            }
            else
            {
                LabelInicio.Text = "Iniciar Sesion";
            }

            //this.BindingContext = new MainPageViewModels();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        //boton del Menu
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

            var mainPage = (Application.Current.MainPage as NavigationPage).CurrentPage;

            if ((mainPage as MasterDetailPage).IsPresented)
            {
                (mainPage as MasterDetailPage).IsPresented = false;

            }
            else
            {
                (mainPage as MasterDetailPage).IsPresented = true;
            }
        }
        private async void InicioUsuario(object sender, EventArgs e)
        {
            var mainPage = (Application.Current.MainPage as NavigationPage).CurrentPage;
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Usuario.txt");
            if (File.Exists(fileName))
            {

                string leer = File.ReadAllText(fileName);
                if (leer.Equals("Estudiante") || leer.Equals("Docente"))
                {

                    await display();
                }
                else
                    await Navigation.PushAsync(new PaginaUsuario());

            }
            else
                await Navigation.PushAsync(new PaginaUsuario());


            (mainPage as MasterDetailPage).Master = new Menu();

        }
        private void InicioRedes(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagLatRedes("http/utb.edu.bo"));

        }
        private void InicioHacerca(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagLatHacerca());

        }
        private void VerMaterias(object sender, EventArgs e)
        {
        }
        private void InicioConfiguracion(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagLatConfig());

        }
        private void InicioCerrar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagLatCerrar());


        }
        private async void CerrarApp(object sender, EventArgs e)
        {
           await display();
        }
        //cerrar aplicacion
        private async Task display()
        {
            var ans = await DisplayAlert("Cerrar Sesión?", "Estas seguro que quieres cerrar sesión?", "Si", "No");

            if (ans == true)
            {
                var mainPage = (Application.Current.MainPage as NavigationPage).CurrentPage;
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Usuario.txt");
                DependencyService.Get<IFileHelper>().UnSuscribeTopic(File.ReadAllText(fileName));
                File.WriteAllText(fileName, "Invitado");
                DependencyService.Get<IFileHelper>().SuscribeTopic("Invitado");
                ICollection<ResourceDictionary> mergedDictionaries1 = Application.Current.Resources.MergedDictionaries;
                mergedDictionaries1.Add(new Invitado());
                UnsuscribeTemas();




                (mainPage as MasterDetailPage).Master = new Menu();
                await Navigation.PopAsync();
                
            }
            else
            {
            }
        }

        private void UnsuscribeTemas()
        {
            List<Verificacion_Usuario> u = new List<Verificacion_Usuario>();
            u = database1.GetUsuarios();

            if (u[0].rol.Equals("acad_estudiante"))
            {

                MateriaDataBase database1 = new MateriaDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("usuariodb.db3"));
                CarreraDatabase database2 = new CarreraDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("usuariodb.db3"));
                var ele = database1.GetUsuarios();
                var ele1 = database2.GetCarreras();
                var TemaTipo = "Estudiante";
                DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTipo);
                var TemaCarrera = CastearCarrera(ele1[0].nombre_carrera);
                var TemaTurno = ele[0].turno;
                var TemaUnidad = CastearUnidad(ele[0].unidad_academica);
                for (int i = 0; i < ele1.Count; i++)
                {
                    TemaCarrera = CastearCarrera(ele[0].nombre_carrera);
                    TemaTurno = ele[0].turno;
                    TemaUnidad = CastearUnidad(ele[0].unidad_academica);



                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaCarrera);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTurno);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaUnidad);

                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTipo + TemaCarrera);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTipo + TemaCarrera + TemaTurno);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTipo + TemaCarrera + TemaTurno + TemaUnidad);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTipo + TemaTurno);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTipo + TemaTurno + TemaUnidad);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTipo + TemaUnidad);

                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaCarrera + TemaTurno);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaCarrera + TemaUnidad);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaCarrera + TemaTurno + TemaUnidad);

                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTurno + TemaUnidad);
                }
            }
            else
            {
                MateriaDocenteDataBase database11 = new MateriaDocenteDataBase(DependencyService
            .Get<IFileHelper>()
            .GetLocalFilePath("usuariodb.db3"));



                u = database1.GetUsuarios();
                var m = database11.GetMaterias();
                string[] TemaCarreraDocente = new string[m.Count];
                string[] TemaUnidadDocente = new string[m.Count];
                string[] TemaTurnoDocente = new string[m.Count];
                var TemaTipo = "Docente";
                for (int i = 0; i < m.Count; i++)
                {
                    TemaCarreraDocente[i] =CastearCarrera( m[i].nombre_carrera);
                    TemaTurnoDocente[i] = m[i].turno;
                    TemaUnidadDocente[i] = CastearUnidad( m[i].sede);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTipo);

                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaCarreraDocente[i]);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTurnoDocente[i]);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaUnidadDocente[i]);

                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTipo + TemaCarreraDocente[i]);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTipo + TemaCarreraDocente[i] + TemaTurnoDocente[i]);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTipo + TemaCarreraDocente[i] + TemaTurnoDocente[i] + TemaUnidadDocente[i]);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTipo + TemaCarreraDocente[i] + TemaUnidadDocente[i]);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTipo + TemaTurnoDocente[i]);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTipo + TemaTurnoDocente[i] + TemaUnidadDocente[i]);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTipo + TemaUnidadDocente[i]);

                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaCarreraDocente[i] + TemaTurnoDocente[i]);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaCarreraDocente[i] + TemaUnidadDocente[i]);
                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaCarreraDocente[i] + TemaTurnoDocente[i] + TemaUnidadDocente[i]);

                    DependencyService.Get<IFileHelper>().UnSuscribeTopic(TemaTurnoDocente[i] + TemaUnidadDocente[i]);


                }
            }
            database1.DeleteAll();
            using (SQLiteConnection conn = new SQLiteConnection(DependencyService.Get<IFileHelper>().GetLocalFilePath("usuariodb.db3")))
            {
                conn.Table<Verificacion_Usuario>();
                conn.Table<Carreras_Estudiante>();
                conn.Table<Horarios_Aula_Estudiante>();
                conn.Table<Lista_Estudiantes_Materia>();
                conn.Table<Materias_Estudiante>();
                conn.Table<Materias_Docente>();
                conn.DeleteAll<Verificacion_Usuario>();
                conn.DeleteAll<Carreras_Estudiante>();
                conn.DeleteAll<Horarios_Aula_Estudiante>();
                conn.DeleteAll<Lista_Estudiantes_Materia>();
                conn.DeleteAll<Materias_Estudiante>();
                conn.DeleteAll<Materias_Docente>();

            }
        }
        private string CastearUnidad(string unidad_academica)
        {
            string Unidad = unidad_academica;
            if (unidad_academica.Equals("EL ALTO-ANTIGUOS"))
            {
                Unidad = "ELALTO";
            }
            if (unidad_academica.Equals("EL ALTO"))
            {
                Unidad = "ELALTO";
            }
            if (unidad_academica.Equals("LA PAZ"))
            {
                Unidad = "LAPAZ";
            }
            return Unidad;

        }

        private string CastearCarrera(string nombre_carrera)
        {
            string carrera = nombre_carrera;
            switch (nombre_carrera)
            {
                case ("INGENIERIA ELECTRONICA"):
                    carrera = "INGELE";
                    break;
                case ("INGENIERIA EN ECOLOGIA Y MEDIO AMBIENTE"):
                    carrera = "INGECO";
                    break;
                case ("INGENIERIA DE SISTEMAS"):
                    carrera = "INGSIS";
                    break;
                case ("DERECHO"):
                    carrera = "DERECH";
                    break;
                case ("INGENIERIA CIVIL"):
                    carrera = "INGCIV";
                    break;
                case ("INGENIERIA COMERCIAL"):
                    carrera = "INGCOM";
                    break;
                case ("COMERCIO INTERNACIONAL"):
                    carrera = "COMINT";
                    break;
                case ("CONTADURIA PUBLICA"):
                    carrera = "CONPUB";
                    break;
                case ("ADMINISTRACION DE EMPRESAS"):
                    carrera = "ADMEMP";
                    break;
                case ("PROGRAMA COMPLEMENTARIO EN CONTADURIA PUBLICA"):
                    carrera = "CONPUB";
                    break;
                case ("MARKETING Y DIRECCION COMERCIAL"):
                    carrera = "MARKET";
                    break;
                case ("VENTAS Y COMERCIALIZACION"):
                    carrera = "VENCOM";
                    break;
                case ("COMUNICACIÓN Y TECNOLOGIAS DIGITALES"):
                    carrera = "COMTEC";
                    break;
                case ("TURISMO Y HOTELERIA"):
                    carrera = "TURHOT";
                    break;
                case ("PSICOLOGIA"):
                    carrera = "PSICOL";
                    break;
                case ("PROFESIONALIZACION EN ADUANAS Y COMERCIO EXTERIOR"):
                    carrera = "COMEXT";
                    break;
            }
            return carrera;
        }

        /*  private void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {

     var c = sender.GetHashCode();
     int menu = e.SelectedItemIndex;


     if (menu == 0)
     {

         Navigation.PushAsync(new PagLatUsuario());
     }

     if (menu == 1)
     {
         Navigation.PushAsync(new PagLatHacerca());
     }
     if (menu == 2)
     {
         Navigation.PushAsync(new PagLatConfig());

     }
     if (menu == 3)

     {
         this.display();




     }


    }*/


        private async void OpenWhatsApp(object sender, EventArgs e)
        {
            try
            {
                string mensaje = "";
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Usuario.txt");
                if (File.Exists(fileName))
                {
                    if (File.ReadAllText(fileName).Equals("Invitado"))
                    {
                        mensaje = "Saludos!! Soy Usuario De La Aplicación y me gustaria más información Sobre la Universidad.";
                    }
                    else
                    {
                        if (File.ReadAllText(fileName).Equals("Estudiante"))
                        {
                            mensaje = "Saludos!! soy Estudiante de la Universidad Tecnologica Boliviana y quiero comunicarme con ustedes.";
                        }
                        else
                            mensaje = "Saludos!! Soy Docente de la Universidad Tecnologica Boliviana y quiero comunicarme con ustedes.";
                    }
                }
                else
                    mensaje = "Saludos!! Soy Usuario De La Aplicación y me gustaria más información Sobre la Universidad.";

                Chat.Open("+591 68081180", mensaje);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
        private async void OpenFacebook(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/114692885274035"));
        }
        private async void OpenTwitter(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://twitter.com/UTB_EDU_BO"));
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}