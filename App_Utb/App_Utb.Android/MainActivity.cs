
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;

using Firebase.Analytics;
using Plugin.CurrentActivity;
using System;
using System.IO;
using App_Utb.Droid.Services;
using Android.Content;
using Android;
using Android.Support.V4.App;
using Android.Gms.Common;
using Android.Widget;
using Firebase.Messaging;

namespace App_Utb.Droid
{
    [Activity(ScreenOrientation = ScreenOrientation.Portrait, Label = "App_Utb", Icon = "@drawable/logo", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation),]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        internal static readonly string CHANNEL_ID = "my_notification_channel";
        internal static readonly int NOTIFICATION_ID = 100;
        private static MainActivity activity_llamadas;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(savedInstanceState);

            Xamarin.Forms.Forms.Init(this, savedInstanceState);
            Syncfusion.XForms.Android.Core.Core.Init(this);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            string name = "Notificacion_db.db3";
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string completePath = Path.Combine(path,name);

            //LoadApplication(new App(completePath));
            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);
            activity_llamadas = this;
            Xamarin.FormsMaps.Init(this, savedInstanceState);
            CrossCurrentActivity.Current.Init(this, savedInstanceState);
            string FileUsu2 = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "Usuario.txt");
            if (!File.Exists(FileUsu2))
            {
                FirebaseMessaging.Instance.SubscribeToTopic("Invitado");
            }
            CheckForGoogleServices();
            bool flag = false;
            if (Intent.Extras != null)
            {
                flag = true;
            }

            LoadApplication(new App(completePath, flag));
            IsPlayServicesAvailable();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public bool CheckForGoogleServices()
        {
            int resultCode = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this);
            if (resultCode != ConnectionResult.Success)
            {
                if (GoogleApiAvailability.Instance.IsUserResolvableError(resultCode))
                {
                    Toast.MakeText(this, GoogleApiAvailability.Instance.GetErrorString(resultCode), ToastLength.Long);
                }
                else
                {
                    Toast.MakeText(this, "This device does not support Google Play Services", ToastLength.Long);
                }
                return false;
            }
            return true;
        }
        private void verifyPermission()
        {
            int permsRequestCode = 100;
            String[] perms = { Android.Manifest.Permission.AccessFineLocation, Manifest.Permission.AccessCoarseLocation, Manifest.Permission.WriteExternalStorage };
            var accessFinePermission = CheckSelfPermission(Manifest.Permission.AccessFineLocation);
            var accessCoarsePermission = CheckSelfPermission(Manifest.Permission.ReadExternalStorage);
            var cameraPermission = CheckSelfPermission(Manifest.Permission.WriteExternalStorage);
            RequestPermissions(perms, permsRequestCode);
        }

        public static Activity getmInstanceActivity()
        {
            return activity_llamadas;
        }

        //Nuevo metodo
        public bool IsPlayServicesAvailable()
        {
            int resultCode = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this);
            if (resultCode != ConnectionResult.Success)
            {

                if (GoogleApiAvailability.Instance.IsUserResolvableError(resultCode))
                {
                    //msgText.Text = GoogleApiAvailability.Instance.GetErrorString(resultCode);
                }

                else
                {
                    // msgText.Text = "This device is not supported";
                    Finish();
                }
                return false;
            }
            else
            {
                // do whatever if play service is not available
                //msgText.Text = "Google Play Services is available.";
                return true;
            }
        }

    }
}