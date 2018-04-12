using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

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

            var username = (EditText)FindViewById(Resource.Id.username);
            var password = (EditText)FindViewById(Resource.Id.password);
            Button btnLogin = (Button)FindViewById(Resource.Id.btnLogin);
            Button btnRegister = FindViewById<Button>(Resource.Id.btnRegister);
            
            btnLogin.Click += delegate {
                //if()
                //{
                    Intent nextActivity = new Intent(this, typeof(HomeActivity));

                    StartActivity(nextActivity);
                //}
            };

            btnRegister.Click += delegate
            {
                Intent registerActivity = new Intent(this, typeof(RegisterActivity));
                StartActivity(registerActivity);
            };
        }
    }
}

