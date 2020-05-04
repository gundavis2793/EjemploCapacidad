using App_Utb.Data;
using App_Utb.Modelos;
using App_Utb.ViewModels;
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
    public partial class MostrarUsuario : MasterDetailPage
    {
        public MostrarUsuario()
        {
            InitializeComponent();
            UsuarioDatabase database = new UsuarioDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("usuariodb.db3"));
            Verificacion_Usuario usuario = database.GetUsuarios()[0];
            this.BindingContext = usuario;
            NombreEstu.Text = usuario.nombre;
            APPaterno.Text = usuario.ap_paterno;
            APMaterno.Text = usuario.ap_materno;
            string base64Image = usuario.avatar;
            byte[] Base64Stream = Convert.FromBase64String(base64Image);
            Img.Source = ImageSource.FromStream(() => new MemoryStream(Base64Stream));
        }


        protected  override  bool OnBackButtonPressed()
        {

            return base.OnBackButtonPressed();
            Navigation.PopToRootAsync();

        }
    }
}