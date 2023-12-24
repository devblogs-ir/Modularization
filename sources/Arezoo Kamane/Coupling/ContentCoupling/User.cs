using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling.ContentCoupling
{
    public class User
    {
        private string username;
        private string password;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void PrintUserInfo()
        {
            Console.WriteLine($"User Info - Username: {username}, Password: {password}");
        }
    }
}
