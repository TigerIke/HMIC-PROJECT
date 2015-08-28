using System.Threading;
using Android.App;
using Android.OS;

namespace HANGMAN
{
    [Activity(Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true, Icon = "@drawable/hmsetup3")]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Thread.Sleep(5000); // Simulate a long loading process on app startup.
            StartActivity(typeof(MainActivity));
        }
    }
}

