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
    public class OperationsModel
    {
        public string amount_uah { get; set; }
        public string amount_wex_usd { get; set; }
        public string amount_btc { get; set; }
        public string id { get; set; }
        public string rate_uah_usd { get; set; }
        public string rate_usd_btc { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string type_name { get; set; }
        public string details { get; set; }
        public string created_at { get; set; }
    }
}