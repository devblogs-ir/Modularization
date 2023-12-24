using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling.CommonCoupling
{
    public class UserProfileModule
    {
        public static void ViewUserProfile(int userId)
        {
            User user = UserRepository.GetUserById(userId);

            if (user != null)
            {
                Console.WriteLine($"User Profile:\n{user}");
            }
            else
            {
                Console.WriteLine($"User with ID {userId} not found.");
            }
        }
    }
}
