using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using EmployeeApp.Domain;
namespace EmployeeApp.Screens
{
    [Activity(Label = "EmployeeApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class EmployeeDetailsActivity : Activity
    {
       
     
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.EmployeeDetails);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate {


                EditText textname = FindViewById<EditText>(Resource.Id.textName);
                EditText textDOB = FindViewById<EditText>(Resource.Id.textDOB);
                EditText textPhone = FindViewById<EditText>(Resource.Id.textPhone);
                 
                RadioGroup rd = FindViewById<RadioGroup>(Resource.Id.radioGroup1);
                Employee employee = new Employee();
                employee.FirstName = textname.Text;
                employee.DOB = textDOB.Text;
                employee.Phone = textPhone.Text;

                RadioButton rdMale = FindViewById<RadioButton>(Resource.Id.radioButton1);
                
                var employeeDetails = new Intent(this, typeof(EmployeeDetailsPreviewActivity));
                 
               employeeDetails.PutExtra("name", employee.FirstName);
               employeeDetails.PutExtra("dob", employee.DOB);
               employeeDetails.PutExtra("phone", employee.Phone);
               if (rdMale.Selected)
               {
                   employeeDetails.PutExtra("gender", "Male");
               }
               else
               {
                   employeeDetails.PutExtra("gender", "Female");
               }
                StartActivity(employeeDetails);
              //  employee.DOB = textdob.;
                
            
            };
        }


     
    }
}

