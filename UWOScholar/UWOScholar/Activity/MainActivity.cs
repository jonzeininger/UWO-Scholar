using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace UWOScholarAndroid
{
    [Activity(Label = "UWOScholar", MainLauncher = true)]
    public class MainActivity : Activity
    {
        EditText txtUsername;
        EditText txtPassword;
        Button btnLogin;
        Button btnRegister;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            txtUsername = (EditText)FindViewById(Resource.Id.username);
            txtPassword = (EditText)FindViewById(Resource.Id.password);
            btnLogin = (Button)FindViewById(Resource.Id.btnLogin);
            btnRegister = FindViewById<Button>(Resource.Id.btnRegister);

            btnLogin.Click += BtnLogin_Click;
            btnRegister.Click += BtnRegister_Click;
        }
        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
                Intent nextActivity = new Intent(this, typeof(HomeActivity));

                StartActivity(nextActivity);
        }
        private void BtnRegister_Click(object sender, System.EventArgs e)
        {
            Intent registerActivity = new Intent(this, typeof(RegisterActivity));
            StartActivity(registerActivity);
        }
    }
}

