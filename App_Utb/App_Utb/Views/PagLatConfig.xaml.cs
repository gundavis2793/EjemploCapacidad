using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xamarin.Forms;
using App_Utb.Themes;
using Xamarin.Forms.Xaml;
using App_Utb.Services;
using System.IO;

namespace App_Utb
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagLatConfig : ContentPage, IModalPage
    {
        public PagLatConfig()
        {
            InitializeComponent();
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Tema.txt");
            if(File.Exists(fileName))
                {
                if (File.ReadAllText(fileName).Equals("Claro"))
                {
                    radio2.IsChecked = true;


                }
                else
                {
                    if (File.ReadAllText(fileName).Equals("Oscuro"))
                    {
                        radio3.IsChecked = true;
                    }
                    else
                    {
                        radio1.IsChecked = true;
                    }
                }
            }
            else { radio1.IsChecked = true; }
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;

        }

        void OnPickerSelectionChanged(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;
            Theme theme = (Theme)picker.SelectedItem;
            
           string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Tema.txt");

            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();

                switch (theme)
                {
                    case Theme.Original:
                    default:
                        mergedDictionaries.Add(new Original());
                       File.WriteAllText(fileName, "Original");
                        radio1.IsChecked = true;
                        break;
                    case Theme.Claro:
                        mergedDictionaries.Add(new Claro());
                       File.WriteAllText(fileName, "Claro");
                        radio2.IsChecked = true;
                        break;
                    case Theme.Oscuro:                    
                        mergedDictionaries.Add(new Oscuro());
                       File.WriteAllText(fileName, "Oscuro");
                        radio3.IsChecked = true;
                        break;
                }
             //   statusLabel.Text = $"{theme.ToString()} tema establecido. Cierre la pagina para aplicar.";
            }
        }

        public async  Task Dismiss()
        {
            await Navigation.PopModalAsync();
        }

        private void Original(object sender, EventArgs e)
        {
            
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Tema.txt");
            mergedDictionaries.Add(new Original());
            File.WriteAllText(fileName, "Original");
        }
        private void Claro(object sender, EventArgs e)
        {
          
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Tema.txt");
            mergedDictionaries.Add(new Claro());
            File.WriteAllText(fileName, "Claro");


        }
        private void Oscuro(object sender, EventArgs e)
        {
            
            radio3.IsChecked = true;
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Tema.txt");
            mergedDictionaries.Add(new Oscuro());
            File.WriteAllText(fileName, "Oscuro");
        }
    }
}