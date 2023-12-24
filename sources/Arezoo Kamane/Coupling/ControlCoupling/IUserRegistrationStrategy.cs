using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling.ControlCoupling
{
    public interface IUserRegistrationStrategy
    {
        void RegisterUser(string userName);
    }

    public class EmailVerificationStrategy : IUserRegistrationStrategy
    {
        public void RegisterUser(string userName)
        {
            Console.WriteLine($"Registering user '{userName}' with email verification");
        }
    }

    public class AdminApprovalStrategy : IUserRegistrationStrategy
    {
        public void RegisterUser(string userName)
        {
            Console.WriteLine($"Registering user '{userName}' with admin approval");
        }
    }
}
