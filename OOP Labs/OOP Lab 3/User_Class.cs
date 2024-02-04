using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challanege3
{
    public class users
    {
        public string Username;
        public string Password;
        public string Role;

        public users(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }

}
