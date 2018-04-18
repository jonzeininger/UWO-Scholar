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
using UWOScholarAndroid;

namespace UWOScholar
{
    [Activity(Label = "FolderActivity")]
    public class FolderActivity : Activity
    {
        Toolbar toolbarTop;
        Toolbar menuBottom;
        private List<string> folders;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Folder);

            menuBottom = FindViewById<Toolbar>(Resource.Id.menu);
            menuBottom.Title = "Menu";
            menuBottom.InflateMenu(Resource.Menu.pageMenu);
            menuBottom.MenuItemClick += (sender, e) =>
            {
                var menuClicked = e.Item.TitleFormatted;
                if (menuClicked.ToString() == "Folder")
                {
                    Intent folderActivity = new Intent(this, typeof(FolderActivity));
                    StartActivity(folderActivity);
                }
                else if (menuClicked.ToString() == "Home")
                {
                    Intent homeActivity = new Intent(this, typeof(HomeActivity));
                    StartActivity(homeActivity);
                }
            };

            toolbarTop = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbarTop);
            ActionBar.Title = "My Backpack";
        }
    }
}