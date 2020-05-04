
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagLatRedes : ContentPage
    {
        public PagLatRedes(string dir)
        {
            InitializeComponent();
            this.BindingContext = dir;
        }
    }
}