using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCU.Models
{
    public class LoginRequestModel
    {
        public string login { get; set; }
        public string password { get; set; }
        public string application_id { get; set; }
        public string recaptcha { get; set; } = "123";
        public bool remember { get; set; } = false;
    }
}
