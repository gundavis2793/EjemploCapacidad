using Android.App;
using Android.Content;
using System.Threading.Tasks;

namespace App_Utb.Droid
{
    [Activity(Theme = "@style/MyTheme.Splash",
              MainLauncher = true,
              NoHistory = true, Icon = "@drawable/logo")]
    class SplashScreenActivity : Activity
    {

        protected override void OnResume()
        {

            base.OnResume();
            Task.Run(() =>
            {

                StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            });

        }
    }
}