using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_encapsulation.Models
{
    internal class Login
    {
        public string email;
        private string _password;

        public bool ChangePassword(string password)
        {
            if (_password is null) 
            {
                _password = password;
                return true;
            }
            return false;
        }

        public bool CheckUser(string email, string password) 
        {
            return this.email == email && _password == password;
        }

    }
}
