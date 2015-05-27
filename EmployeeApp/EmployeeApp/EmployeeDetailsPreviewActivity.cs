
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System;
using System.Text;

namespace EmployeeApp.Screens
{
    [Activity(Label = "EmployeeDetailsPreviewActivity")]
    public class EmployeeDetailsPreviewActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
          SetContentView(Resource.Layout.EmployeeDetailsPreview);

          TextView textShow = FindViewById<TextView>(Resource.Id.textEmployeeDetails);
            string name =  Intent.GetStringExtra("name");
            string dob =  Intent.GetStringExtra("dob");
            string phone =  Intent.GetStringExtra("phone");
            string gender = Intent.GetStringExtra("gender");
            string prefix =( gender =="male" ? "gentleman" : "lady");

          StringBuilder sb = new StringBuilder();
          sb.AppendFormat("Welcome {0} to employee portal!\n", name);
          sb.AppendLine("Your details are as below:" );
          sb.AppendFormat("Your dob is :{0} \n", dob);
          sb.AppendFormat("Your phone number is :{0} \n", phone);
          textShow.Text = sb.ToString();
          Button goBackButton = FindViewById<Button>(Resource.Id.GoBack);
          goBackButton.Click += (sender, e) => { GoBack(); };
            // Create your application here
        }

        void GoBack()
        {
            
            Finish();
        }
    }
}