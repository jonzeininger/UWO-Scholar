using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using UWOScholarAndroid;

namespace UWOScholar
{
    [Activity(Label = "FolderActivity")]
    public class FolderActivity : AppCompatActivity
    {
        Toolbar toolbarTop;
        Toolbar menuBottom;
        Button btnAddFolder;
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


            btnAddFolder = FindViewById<Button>(Resource.Id.btnAddFolder);
            btnAddFolder.Click += BtnAddFolder_Click;
        }

        private void BtnAddFolder_Click(object sender, System.EventArgs e)
        {
            LayoutInflater addFolderLayoutInflator = LayoutInflater.From(this);
            View popupView = addFolderLayoutInflator.Inflate(Resource.Layout.UserInputFolder);
            Android.Support.V7.App.AlertDialog.Builder alertDialogBuilder = new Android.Support.V7.App.AlertDialog.Builder(this);
            alertDialogBuilder.SetView(popupView);

            var folderTitle = popupView.FindViewById<EditText>(Resource.Id.editText1);
        }
    }
}