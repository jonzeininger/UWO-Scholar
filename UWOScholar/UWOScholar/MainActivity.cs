using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using UWOScholar;
using SQLite;
using System.IO;
using System;
using Android.Views;

namespace UWOScholarAndroid
{
    [Activity(Label = "UWO Scholar", MainLauncher = true)]
    public class MainActivity : Activity
    {
        EditText txtUsername;
        EditText txtPassword;
        Button btnLogin;
        Button btnRegister;
        Toolbar toolbarLogin;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Saves values of UI to variables
            txtUsername = FindViewById<EditText>(Resource.Id.username);
            txtPassword = FindViewById<EditText>(Resource.Id.password);
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            btnRegister = FindViewById<Button>(Resource.Id.btnRegister);

            //Creates the click event for each button
            btnLogin.Click += BtnLogin_Click;
            btnRegister.Click += BtnRegister_Click;

            //Call the method to create the database
            CreateDB();

            //Creates and sets the toolbar for the Main Page.
            toolbarLogin = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbarLogin);
            ActionBar.Title = "UWO Scholar";
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Call Database
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3");  
                var db = new SQLiteConnection(dpPath);

                //Call Table 
                var data = db.Table<LoginTable>();

                //Linq Query
                var data1 = data.Where(x => x.email == txtUsername.Text || x.username == txtUsername.Text && x.password == txtPassword.Text).FirstOrDefault();   
                if (data1 != null)
                {
                    Intent nextActivity = new Intent(this, typeof(HomeActivity));
                    StartActivity(nextActivity);
                }
                else
                {
                    Toast.MakeText(this, "Username/Email or Password invalid", ToastLength.Short).Show();
                }
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }
             
        }

        private void BtnRegister_Click(object sender, System.EventArgs e)
        {
            Intent registerActivity = new Intent(this, typeof(RegisterActivity));
            StartActivity(registerActivity);
        }
        public string CreateDB()
        {
            var output = "";
            output += "Creating Database if it doesnt exist";

            //Create New Database 
            string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3"); 
            var db = new SQLiteConnection(dpPath);
            output += "\n database Created....";
            return output;
        }
    }
}

