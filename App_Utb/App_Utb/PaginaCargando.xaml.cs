using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Pages;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaCargando : PopupPage
    {
        public ScaleAnimation Animation { get; internal set; }
        public PaginaCargando()
        {
            InitializeComponent();
        }
    }
}