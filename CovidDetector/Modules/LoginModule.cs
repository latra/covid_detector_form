using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidDetector.Modules
{
    public class LoginModule
    {
        public string user { get; set; }
        public string password { get; set; }
        public LoginModule(string user, string password)
        {
            this.user = user;
            this.password = password;
        }
        public bool validate()
        {
            return this.user == "medic1" && this.password == "12345";
        }
        public string getName()
        {
            return "Gregory House";
        }
    }
}
