using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using UWOScholarAndroid.Activity;

namespace UWOScholarAndroid
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        EditText txtEmail;
        EditText txtPassword;
        EditText txtConfirmPassword;
        Button btnCreateAcc;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Register);

            txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
            txtEmail = FindViewById<EditText>(Resource.Id.txtPassword);
            txtEmail = FindViewById<EditText>(Resource.Id.txtConfirmPassword);
            txtEmail = FindViewById<Button>(Resource.Id.btnCreateAcc);

        }
    }
}