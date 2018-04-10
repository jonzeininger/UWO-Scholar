using Android.App;
using Android.Widget;
using Android.OS;

namespace UWOScholar
{
    [Activity(Label = "UWOScholar", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var username = FindViewById<EditText>(Resource.Id.username);
            var password = FindViewById<EditText>(Resource.Id.password);
            Button btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            Button btnRegister = FindViewById<Button>(Resource.Id.btnRegister);
            
            btnLogin.Click += delegate {
                if(username.ToString() == "Admin" && password.ToString() == "1234")
                {
                    SetContentView(Resource.Layout.Home);
                }
            };
        }
    }
}

