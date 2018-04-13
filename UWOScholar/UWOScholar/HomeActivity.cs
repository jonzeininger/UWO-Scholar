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
using UWOScholar;

namespace UWOScholarAndroid
{
    [Activity(Label = "Home")]
    public class HomeActivity : Activity
    {
        Toolbar homeToolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Home);

            homeToolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(homeToolbar);
            ActionBar.Title = "UWO Scholar Home";

        
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.top_menus, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            Toast.MakeText(this, "Action selected: " + item.TitleFormatted, ToastLength.Short).Show();
            return base.OnOptionsItemSelected(item);
        }
    }
}