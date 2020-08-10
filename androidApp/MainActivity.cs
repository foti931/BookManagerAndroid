using System;
using System.Linq;
using System.Net.Http;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Widget;
using androidApp.API.model;
using ZXing.Mobile;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace androidApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button scanbutton;
        private EditText edittext;
        private ProgressBar progbar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            ZXing.Net.Mobile.Forms.Android.Platform.Init();
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            scanbutton = FindViewById<Button>(Resource.Id.btnscan);
            scanbutton.Click += OnScanButtonClick;

            edittext = FindViewById<EditText>(Resource.Id.editText1);
            progbar = FindViewById<ProgressBar>(Resource.Id.progressBar1);
            progbar.Visibility = Android.Views.ViewStates.Invisible;
        }

        /// <summary>
        /// バーコードスキャン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnScanButtonClick(object sender, EventArgs e)
        {


            MobileBarcodeScanner.Initialize(Application);

            var scanner = new ZXing.Mobile.MobileBarcodeScanner();

            var scanresult = await scanner.Scan();

            //読み取り失敗
            if (scanresult == null) return;

            progbar.Visibility = Android.Views.ViewStates.Visible;

            HttpClient client = new HttpClient();

            //Uri uri = new Uri(string.Format("https://api.openbd.jp/v1/get?isbn={0}&pretty", scanresult.Text));
            Uri uri = new Uri("https://tagkuyaapp.azurewebsites.net/book");

            HttpResponseMessage response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();

                try
                {
                    //var bookInfo = JsonConvert.DeserializeObject<List<OpenBDResponce>>(content);
                    var bookInfo = JsonConvert.DeserializeObject<List<Book>>(content);

                    edittext.Text = bookInfo.FirstOrDefault().Title;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.StackTrace);
                    progbar.Visibility = Android.Views.ViewStates.Invisible;
                }
            }
            progbar.Visibility = Android.Views.ViewStates.Invisible;
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            global::ZXing.Net.Mobile.Android.PermissionsHandler.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
