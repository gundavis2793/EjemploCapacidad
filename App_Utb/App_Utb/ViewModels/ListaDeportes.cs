using App_Utb.Data;
using App_Utb.JsonModels;
using App_Utb.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App_Utb.ViewModels
{
    public class ListaDeportes
    {
        IFileHelper downloader = DependencyService.Get<IFileHelper>();
        public List<Noticia> Deportes { get; set; }
        public ListaDeportes()
        {
            NoticiaDatabase databaseNoticia = new NoticiaDatabase(DependencyService
                                .Get<IFileHelper>()
                                .GetLocalFilePath("deportesdb.db3"));
           Deportes = databaseNoticia.GetNorticias();
            downloader.OnFileDownloaded += OnFileDownloaded;

        }
        private void OnFileDownloaded(object sender, DownloadEventArgs e)
        {
            if (e.FileSaved)
            {
                Console.WriteLine("XF Downloader", "File Saved Successfully", "Close");
            }
            else
            {
                Console.WriteLine("XF Downloader", "Error while saving the file", "Close");
            }
        }

        public async  void GetJSON()
        {
            List<Noticia> ListNoti = new List<Noticia>();
            //Check network status 
            if (NetWorkCheck.IsInternet())
            {
                NoticiaDatabase databaseNoticia = new NoticiaDatabase(DependencyService
                                .Get<IFileHelper>()
                                .GetLocalFilePath("deportesdb.db3"));
                var client = new System.Net.Http.HttpClient();
                var response = await client.GetAsync("http://utb.edu.bo/wp-json/wp/v2/posts?categories=62");
                string contactsJson = response.Content.ReadAsStringAsync().Result;
                Deportes = new List<Noticia>();
                List<Class1> ele = new List<Class1>();
                Rootobject ObjNoticiasList = new Rootobject();
                if (contactsJson != "")
                {
                    //Converting JSON Array Objects into generic list
                    ele = JsonConvert.DeserializeObject<List<Class1>>(contactsJson);
                }
                Deportes = databaseNoticia.GetNorticias();

                if (ele.Count != Deportes.Count)
                {
                    databaseNoticia.DeleteAll();
                    if (ele != null)
                    {
                        Noticia noticia = new Noticia();
                        for (int i = 0; i < ele.Count; i++)

                        {
                            noticia.IdNoticia = ele[i].id;
                            noticia.titulo = ele[i].title.rendered;
                            noticia.contenido = ele[i].content.rendered;
                            noticia.fecha = ConfigFecha(ele[i].date.ToString().Substring(0, 10));

                            var response1 = await client.GetAsync(ele[i]._links.wpfeaturedmedia[0].href);
                            string ImageJson1 = response1.Content.ReadAsStringAsync().Result;

                            var ObjImagenList1 = JsonConvert.DeserializeObject<ImageJson>(ImageJson1);
                            var url = ObjImagenList1.media_details.sizes.thumbnail.source_url;
                            var urlImage = ObjImagenList1.media_details.sizes.medium_large.source_url;
                            downloader.DownloadFile(url, "UtbApp/Image/Deportes");
                            downloader.DownloadFile(urlImage, "UtbApp/Image/Deportes");
                            string path = downloader.GetDirectory("UtbApp/Image/Deportes");

                            noticia.imagen = Path.Combine(path, ObjImagenList1.media_details.sizes.medium_large.file);
                            noticia.imagenIcono = Path.Combine(path, ObjImagenList1.media_details.sizes.thumbnail.file);
                            databaseNoticia.InsertNoti(noticia);
                        }
                    }
                }

            }


        }
        private string ConfigFecha(string v)
        {
            string[] cad;
            cad = v.Split("/".ToCharArray());
            return cad[1] + "/" + cad[0] + "/" + cad[2];
        }
        public IList<Noticia> GetAll()
        {
            return (Deportes);
        }
        public IList<Noticia> GetAll(string ele)
        {
            return (Deportes);
        }
    }
}
