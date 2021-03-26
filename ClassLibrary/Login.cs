using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Login
    {
        public bool ValidateUser(string username, string password)
        {
            if (username.Equals("Preety") && password.Equals("Password123#"))
                return true;
            else
                return false;
        }
    }
}
