using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
using App_Utb.ViewModels;
using App_Utb.Modelos;

namespace App_Utb.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IniciarTest : MasterDetailPage
    {
        private ObservableCollection<RootObject> _rootobj;
        private int i = 0;
        public double CienEducacion = 0, CienEcono = 0, CienSalud = 0, CienSociales = 0,
            CienExactas = 0, ArteArqui = 0, Ingenieria = 0, CienBiologicas = 0;
        private int sw = 0;
        public Resultados res = new Resultados();
        public IniciarTest()
        {
            InitializeComponent();
            BindingContext = this;
            var assembly = typeof(PaginaTest).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("App_Utb.Test.json");


            using (var reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                json=json.ToString();
                List<RootObject> mylist = JsonConvert.DeserializeObject<List<RootObject>>(json);
                _rootobj = new ObservableCollection<RootObject>(mylist);
                PreguntaTest.Text = _rootobj[i].id.ToString() +".-"+ _rootobj[i].pregunta;
                test1.Text = _rootobj[i].primero;
                test2.Text = _rootobj[i].segundo;
                test3.Text = _rootobj[i].tercero;
                NumPregunta.Text = _rootobj[i].id.ToString() + "-32";
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
        private void BootonSiguiente1(object sender, EventArgs e)
        {
            i++;
            if (i < _rootobj.Count)
            {
                PreguntaTest.Text = _rootobj[i].id.ToString() + ".-" + _rootobj[i].pregunta;
                test1.Text = _rootobj[i].primero;
                test2.Text = _rootobj[i].segundo;
                test3.Text = _rootobj[i].tercero;
                NumPregunta.Text = _rootobj[i].id.ToString() + "-32";
            }
            else
            {
                i = _rootobj.Count;
                res.A = CienEducacion;
                res.B = CienEcono;
                res.C = CienSalud;
                res.D = CienSociales;
                res.E = CienExactas;
                res.F = ArteArqui;
                res.G = Ingenieria;
                res.H = CienBiologicas;
                Navigation.PushAsync(new MostrarTest(res));
            }

            test1.IsChecked = false;
        }
        private void BootonSiguiente2(object sender, EventArgs e)
        {
            if (sw == 0)
            {
                CienSociales = CienSociales + 12.5;
                i++;
                PreguntaTest.Text = _rootobj[i].id.ToString() + ".-" + _rootobj[i].pregunta;
                test1.Text = _rootobj[i].primero;
                test2.Text = _rootobj[i].segundo;
                test3.Text = _rootobj[i].tercero;
                NumPregunta.Text = _rootobj[i].id.ToString() + "-32";
                sw = 1;
            }
            else
            {
                if (i < _rootobj.Count)
                {
                    if (_rootobj[i].id == 15 || _rootobj[i].id == 23 ||
                    _rootobj[i].id == 26 || _rootobj[i].id == 30)
                    {
                        CienEducacion = CienEducacion + 12.5;
                    }
                    else
                    {
                        if (_rootobj[i].id == 6 || _rootobj[i].id == 8 ||
                        _rootobj[i].id == 21 || _rootobj[i].id == 31)
                        {
                            CienEcono = CienEcono + 12.5;
                        }
                        else
                        {
                            if (_rootobj[i].id == 2 || _rootobj[i].id == 19 ||
                            _rootobj[i].id == 22 || _rootobj[i].id == 25)
                            {
                                CienSalud = CienSalud + 12.5;
                            }
                            else
                            {
                                if (_rootobj[i].id == 1 || _rootobj[i].id == 11 ||
                                _rootobj[i].id == 14 || _rootobj[i].id == 16)
                                {
                                    CienSociales = CienSociales + 12.5;
                                }
                                else
                                {
                                    if (_rootobj[i].id == 3 || _rootobj[i].id == 9 ||
                                    _rootobj[i].id == 12 || _rootobj[i].id == 13)
                                    {
                                        CienExactas = CienExactas + 12.5;
                                    }
                                    else
                                    {
                                        if (_rootobj[i].id == 20 || _rootobj[i].id == 24 ||
                                        _rootobj[i].id == 27 || _rootobj[i].id == 29)
                                        {
                                            ArteArqui = ArteArqui + 12.5;
                                        }
                                        else
                                        {
                                            if (_rootobj[i].id == 5 || _rootobj[i].id == 7 ||
                                            _rootobj[i].id == 28 || _rootobj[i].id == 32)
                                            {
                                                Ingenieria = Ingenieria + 12.5;
                                            }
                                            else
                                            {
                                                CienBiologicas = CienBiologicas + 12.5;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (i < _rootobj.Count - 1)
                    {
                        i++;
                        PreguntaTest.Text = _rootobj[i].id.ToString() + ".-" + _rootobj[i].pregunta;
                        test1.Text = _rootobj[i].primero;
                        test2.Text = _rootobj[i].segundo;
                        test3.Text = _rootobj[i].tercero;
                        NumPregunta.Text = _rootobj[i].id.ToString() + "-32";
                    }
                    else
                    {
                        i = _rootobj.Count;
                        res.A = CienEducacion;
                        res.B = CienEcono;
                        res.C = CienSalud;
                        res.D = CienSociales;
                        res.E = CienExactas;
                        res.F = ArteArqui;
                        res.G = Ingenieria;
                        res.H = CienBiologicas;
                        Navigation.PushAsync(new MostrarTest(res));
                    }
                }
                else
                {
                    i = _rootobj.Count;
                    res.A = CienEducacion;
                    res.B = CienEcono;
                    res.C = CienSalud;
                    res.D = CienSociales;
                    res.E = CienExactas;
                    res.F = ArteArqui;
                    res.G = Ingenieria;
                    res.H = CienBiologicas;
                    Navigation.PushAsync(new MostrarTest(res));
                }
            }
            test2.IsChecked = false;
        }
        private void BootonSiguiente3(object sender, EventArgs e)
        {
            if (sw == 0)
            {
                CienSociales = CienSociales + 25;
                i++;
                PreguntaTest.Text = _rootobj[i].id.ToString() + ".-" + _rootobj[i].pregunta;
                test1.Text = _rootobj[i].primero;
                test2.Text = _rootobj[i].segundo;
                test3.Text = _rootobj[i].tercero;
                NumPregunta.Text = _rootobj[i].id.ToString() + "-32";
                sw = 1;
            }
            else
            {
                if (i < _rootobj.Count)
                {
                    if (_rootobj[i].id == 15 || _rootobj[i].id == 23 ||
                    _rootobj[i].id == 26 || _rootobj[i].id == 30)
                    {
                        CienEducacion = CienEducacion + 25;
                    }
                    else
                    {
                        if (_rootobj[i].id == 6 || _rootobj[i].id == 8 ||
                        _rootobj[i].id == 21 || _rootobj[i].id == 31)
                        {
                            CienEcono = CienEcono + 25;
                        }
                        else
                        {
                            if (_rootobj[i].id == 2 || _rootobj[i].id == 19 ||
                            _rootobj[i].id == 22 || _rootobj[i].id == 25)
                            {
                                CienSalud = CienSalud + 25;
                            }
                            else
                            {
                                if (_rootobj[i].id == 1 || _rootobj[i].id == 11 ||
                                _rootobj[i].id == 14 || _rootobj[i].id == 16)
                                {
                                    CienSociales = CienSociales + 25;
                                }
                                else
                                {
                                    if (_rootobj[i].id == 3 || _rootobj[i].id == 9 ||
                                    _rootobj[i].id == 12 || _rootobj[i].id == 13)
                                    {
                                        CienExactas = CienExactas + 25;
                                    }
                                    else
                                    {
                                        if (_rootobj[i].id == 20 || _rootobj[i].id == 24 ||
                                        _rootobj[i].id == 27 || _rootobj[i].id == 29)
                                        {
                                            ArteArqui = ArteArqui + 25;
                                        }
                                        else
                                        {
                                            if (_rootobj[i].id == 5 || _rootobj[i].id == 7 ||
                                            _rootobj[i].id == 28 || _rootobj[i].id == 32)
                                            {
                                                Ingenieria = Ingenieria + 25;
                                            }
                                            else
                                            {
                                                CienBiologicas = CienBiologicas + 25;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (i < _rootobj.Count - 1)
                    {
                        i++;
                        PreguntaTest.Text = _rootobj[i].id.ToString() + ".-" + _rootobj[i].pregunta;
                        test1.Text = _rootobj[i].primero;
                        test2.Text = _rootobj[i].segundo;
                        test3.Text = _rootobj[i].tercero;
                        NumPregunta.Text = _rootobj[i].id.ToString() + "-32";
                    }
                    else
                    {
                        i = _rootobj.Count;
                        res.A = CienEducacion;
                        res.B = CienEcono;
                        res.C = CienSalud;
                        res.D = CienSociales;
                        res.E = CienExactas;
                        res.F = ArteArqui;
                        res.G = Ingenieria;
                        res.H = CienBiologicas;
                        Navigation.PushAsync(new MostrarTest(res));
                    }
                }
                else
                {
                    i = _rootobj.Count;
                    res.A = CienEducacion;
                    res.B = CienEcono;
                    res.C = CienSalud;
                    res.D = CienSociales;
                    res.E = CienExactas;
                    res.F = ArteArqui;
                    res.G = Ingenieria;
                    res.H = CienBiologicas;
                    Navigation.PushAsync(new MostrarTest(res));
                }
            }
            test3.IsChecked = false;
        }
    }
}