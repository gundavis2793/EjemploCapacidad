using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Utb.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MostrarNotas : PopupPage
    {
        public ScaleAnimation Animation { get; internal set; }

        public MostrarNotas(int index, List<Modelos.Materias_Estudiante> listaMateriass, List<Modelos.Horarios_Aula_Estudiante> horarios)
        {
            InitializeComponent();
            this.BindingContext = listaMateriass[index];
            UnidadLabel.Text = "UNIDAD: " + horarios[0].ubicacion;
            DiaLabel.Text = horarios[0].dia + " DE " + horarios[0].inicio + " a " + horarios[0].final;
            if (horarios.Count>1)
            {
                HorarioLabel.Text = horarios[1].dia + " DE " + horarios[1].inicio + " a " + horarios[1].final;

            }
            else { HorarioLabel.IsVisible = false; }


        }


    }
}