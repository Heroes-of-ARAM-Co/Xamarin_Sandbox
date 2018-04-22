using Android.App;
using Android.Widget;
using Android.OS;

namespace Sandbox
{
    [Activity(Label = "Sandbox", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            Button button1 = FindViewById<Button>(Resource.Id.button1);
        
            
            

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

