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

namespace EmployeeApp.Domain
{
    public class Employee
    {
        public Employee()
		{
		}

        public string FirstName { get; set; }
        public string LasName { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }

    }
}