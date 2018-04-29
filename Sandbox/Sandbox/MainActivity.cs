using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Content;
using Phoneword;

using Core;
using System.Linq;

namespace Sandbox
{
    [Activity(Label = "Sandbox", MainLauncher = true)]
    public class MainActivity : Activity
    {
        static readonly List<string> phoneNumbers = new List<string>();
        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);




            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button roomSendButton = FindViewById<Button>(Resource.Id.button2);

            roomSendButton.Click += (sender, e) =>
            {
                Sandbox.Models.RoomModel emptyModel = new Models.RoomModel();
                QueryFormer smthRoom  = new QueryFormer(emptyModel);
          

              
            };
           
        }
    }
}

