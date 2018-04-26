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
    [Activity(Label = "ScientificCalculator")]
    public class ScientificCalculator : Activity
    {
        EditText txtValue1;
        EditText txtValue2;
        Button btnAdd;
        Button btnSubtract;
        Button btnMultiply;
        Button btnDivide;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Register);

            txtValue1 = FindViewById<EditText>(Resource.Id.txtValue1);
            txtValue2 = FindViewById<EditText>(Resource.Id.txtValue2);
            btnAdd = FindViewById<Button>(Resource.Id.btnAdd);
            btnSubtract = FindViewById<Button>(Resource.Id.btnSubtract);
            btnMultiply = FindViewById<Button>(Resource.Id.btnMultiply);
            btnDivide = FindViewById<Button>(Resource.Id.btnDivide;



            btnAdd.Click += BtnAdd_Click;
            btnSubtract.Click += BtnSubtract_Click;
            btnMultiply.Click += BtnMultiply_Click;
            btnDivide.Click += BtnDivide_Click;
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            try
            {
                double Value1 = double.Parse(txtValue1.Text);
                double Value2 = double.Parse(txtValue2.Text);
                txtValue1.Text = (Value1 + Value2).ToString();
                txtValue2.Text = "";

            }
            catch
            {

            }
        }

        private void BtnSubtract_Click(object sender, System.EventArgs e)
        {
            try
            {
                double Value1 = double.Parse(txtValue1.Text);
                double Value2 = double.Parse(txtValue2.Text);
                txtValue1.Text = (Value1 - Value2).ToString();
                txtValue2.Text = "";

            }
            catch
            {

            }
        }
        private void BtnMultiply_Click(object sender, System.EventArgs e)
        {
            try
            {
                double Value1 = double.Parse(txtValue1.Text);
                double Value2 = double.Parse(txtValue2.Text);
                txtValue1.Text = (Value1 * Value2).ToString();
                txtValue2.Text = "";

            }
            catch
            {

            }
        }

        private void BtnDivide_Click(object sender, System.EventArgs e)
        {
            try
            {
                double Value1 = double.Parse(txtValue1.Text);
                double Value2 = double.Parse(txtValue2.Text);
                txtValue1.Text = (Value1 / Value2).ToString();
                txtValue2.Text = "";

            }
            catch
            {

            }
        }

    }
}