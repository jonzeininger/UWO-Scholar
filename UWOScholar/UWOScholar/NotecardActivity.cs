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

namespace UWOScholar
{
    [Activity(Label = "NotecardActivity")]
    public class NotecardActivity : Activity
    {
        Button btnCreateCard;
        Button btnEditCard;
        EditText txtFront;
        EditText txtBack;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
}