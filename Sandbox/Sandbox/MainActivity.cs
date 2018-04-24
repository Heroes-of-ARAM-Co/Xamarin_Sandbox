using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Content;
using Phoneword;
using Core;

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

            EditText phoneNumberText = FindViewById<EditText>(Resource.Id.PhoneNumberText);
            TextView translatedPhoneWord = FindViewById<TextView>(Resource.Id.TranslatedPhoneWord);
            Button translateButton = FindViewById<Button>(Resource.Id.TranslateButton);
            Button demaciaButton = FindViewById<Button>(Resource.Id.DemaciaButton);
            TextView demaciaText = FindViewById<TextView>(Resource.Id.DemaciaText);
            Button translationHistoryButton = FindViewById<Button>(Resource.Id.TranslationHistoryButton);
            translateButton.Click += (sender, e) =>
            {
                // Translate user's alphanumeric phone number to numeric
               string translatedNumber = PhonewordTranslator.ToNumber(phoneNumberText.Text);
                if (string.IsNullOrWhiteSpace(translatedNumber))
                {
                    translatedPhoneWord.Text = "";
                }
                else
                {
                    translatedPhoneWord.Text = translatedNumber;
                    phoneNumbers.Add(translatedNumber);
                    translationHistoryButton.Enabled = true;
                }
            };
            demaciaButton.Click += (sender, e) =>
            {
                // Translate user's alphanumeric phone number to numeric
                string translatedNumber = Core.DemaciaFucker.ToBattle();
                demaciaText.Text = translatedNumber;
            };

            translationHistoryButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(TranslationHistoryActivity));
                intent.PutStringArrayListExtra("phone_numbers", phoneNumbers);
               
                StartActivity(intent);
            };
        }
    }
}

