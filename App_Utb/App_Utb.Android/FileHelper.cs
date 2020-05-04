using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using System.Text;

using Android.App;
using Android.Content;
using App_Utb.Droid;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App_Utb.Droid.Services;
using App_Utb.Services;
using System.IO;
using Firebase.Analytics;

using System.Net;
using System.ComponentModel;
using Firebase.Messaging;

[assembly:Dependency(typeof(FileHelper))]
namespace App_Utb.Droid.Services
{

    public class FileHelper : IFileHelper
    {


        FirebaseAnalytics mFirebaseAnalytics;
        public event EventHandler<DownloadEventArgs> OnFileDownloaded;

        public void DownloadFile(string url, string folder)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string pathToNewFolder = Path.Combine(path, folder);
            Directory.CreateDirectory(pathToNewFolder);

            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                string pathToNewFile = Path.Combine(pathToNewFolder, Path.GetFileName(url));
                webClient.DownloadFileAsync(new Uri(url), pathToNewFile);
            }
            catch (Exception ex)
            {
                if (OnFileDownloaded != null)
                    OnFileDownloaded.Invoke(this, new DownloadEventArgs(false));
            }
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                if (OnFileDownloaded != null)
                    OnFileDownloaded.Invoke(this, new DownloadEventArgs(false));
            }
            else
            {
                if (OnFileDownloaded != null)
                    OnFileDownloaded.Invoke(this, new DownloadEventArgs(true));
            }
        }
        public void UnSuscribeTopic(string tema)
        {

            FirebaseMessaging.Instance.UnsubscribeFromTopic(tema);
        }
        public void SuscribeTopic(string tema)
        {
            FirebaseMessaging.Instance.SubscribeToTopic(tema);
        }
        public string GetLocalFilePath(string fileName)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, fileName);
        }
        
        public string GetDirectory(string folder)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string pathToNewFolder = Path.Combine(path, folder);
            return pathToNewFolder;
        }

        //Nuevo metodo
        public void GetTipoUsu()
        {

            if (File.Exists(App.FileUsu))
            {
                string TipoUsu = File.ReadAllText(App.FileUsu);

                mFirebaseAnalytics = FirebaseAnalytics.GetInstance(MainActivity.getmInstanceActivity());

                mFirebaseAnalytics.SetUserProperty("Tipo_Usuario", TipoUsu);

            }
            else
            {
                mFirebaseAnalytics = FirebaseAnalytics.GetInstance(MainActivity.getmInstanceActivity());
                mFirebaseAnalytics.SetUserProperty("Tipo_Usuario", "Invitado");
            }
        }
    }
}