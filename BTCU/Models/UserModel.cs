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

namespace BTCU.Models
{
    public class UserModel
    {
            public string login { get; set; }
            public int two_factor_status { get; set; }
            public string valid_phone { get; set; }
            public string phone { get; set; }
            public string alias { get; set; }
    }
}