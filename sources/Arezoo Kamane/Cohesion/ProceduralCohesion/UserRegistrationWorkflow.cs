namespace Cohesion.ProceduralCohesion
{
    public class UserRegistrationWorkflow
    {
        public User CollectUserInformation()
        {
            Console.WriteLine("Step 1: Collect User Information");
            User user = new User();

            Console.Write("Enter username: ");
            user.Username = Console.ReadLine();

            Console.Write("Enter email address: ");
            user.Email = Console.ReadLine();

            Console.Write("Enter password: ");
            user.Password = Console.ReadLine();

            Console.WriteLine("User information collected successfully.\n");
            return user;
        }

        public bool VerifyEmail(User user)
        {
            Console.WriteLine("Step 2: Verify Email");
            Console.WriteLine($"Verification email sent to {user.Email}. Please verify your email.");
            Console.Write("Enter verification code: ");
            string verificationCode = Console.ReadLine();

            // Simulated verification logic 
            bool isEmailVerified = verificationCode.Equals("123456", StringComparison.OrdinalIgnoreCase);

            if (isEmailVerified)
            {
                Console.WriteLine("Email verified successfully.\n");
                return true;
            }
            else
            {
                Console.WriteLine("Email verification failed. Registration aborted.\n");
                return false;
            }
        }

        public void CreateUserAccount(User user)
        {
            Console.WriteLine("Step 3: Create User Account");
            Console.WriteLine($"User account for {user.Username} created successfully.\n");
        }

        public void CompleteUserRegistration()
        {
            Console.WriteLine("User Registration Workflow Initiated\n");

            User newUser = CollectUserInformation();

            bool isEmailVerified = VerifyEmail(newUser);

            if (isEmailVerified)
            {
                CreateUserAccount(newUser);

                Console.WriteLine("User Registration Workflow Completed Successfully");
            }
            else
            {
                Console.WriteLine("User Registration Workflow Aborted");
            }
        }
    }
}
