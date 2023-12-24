using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling.CommonCoupling
{
    public class RegistrationModule
    {
        public static void RegisterUser(string userName, string email)
        {
            int nextUserId = UserRepository.GetAllUsers().Count + 1;
            User newUser = new User { UserId = nextUserId, UserName = userName, Email = email };
            UserRepository.AddUser(newUser);
            Console.WriteLine($"User registered: {newUser}");
        }
    }
}
