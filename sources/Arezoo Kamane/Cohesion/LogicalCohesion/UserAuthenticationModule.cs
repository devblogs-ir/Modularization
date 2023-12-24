using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesion.LogicalCohesion
{
    public class UserAuthenticationModule
    {

        private readonly List<User> registeredUsers;

        public UserAuthenticationModule()
        {
            registeredUsers = new List<User>
            {
                new User { Username = "arezoo", Password = "pass123" },
            };
        }

        public User AuthenticateUser(string username, string password)
        {
            Console.WriteLine("Task: Authenticate User");
            User user = registeredUsers.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                user.IsAuthenticated = true;
                Console.WriteLine($"User '{username}' authenticated successfully.\n");
            }
            else
            {
                Console.WriteLine($"Authentication failed for user '{username}'.\n");
            }

            return user;
        }

        public void LogoutUser(User user)
        {
            Console.WriteLine("Task: Logout User");
            if (user != null && user.IsAuthenticated)
            {
                user.IsAuthenticated = false;
                Console.WriteLine($"User '{user.Username}' logged out successfully.\n");
            }
            else
            {
                Console.WriteLine("Logout failed. User not authenticated.\n");
            }
        }

        public void ChangePassword(User user, string newPassword)
        {
            Console.WriteLine("Task: Change Password");
            if (user != null && user.IsAuthenticated)
            {
                user.Password = newPassword;
                Console.WriteLine($"Password changed successfully for user '{user.Username}'.\n");
            }
            else
            {
                Console.WriteLine("Password change failed. User not authenticated.\n");
            }
        }
    }
}
