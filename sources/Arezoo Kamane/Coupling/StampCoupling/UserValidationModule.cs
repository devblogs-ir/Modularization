namespace Coupling.StampCoupling
{
    public class UserValidationModule
    {

        private readonly UserRepository userRepository;

        public UserValidationModule(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public bool ValidateUser(UserRecord user)
        {
            Console.WriteLine($"Validating user - UserName: {user.UserName}, Email: {user.Email}");

            if (!userRepository.IsUserNameUnique(user.UserName))
            {
                Console.WriteLine($"Username '{user.UserName}' is not unique. Validation failed.");
                return false;
            }

            if (!userRepository.IsEmailUnique(user.Email))
            {
                Console.WriteLine($"Email '{user.Email}' is not unique. Validation failed.");
                return false;
            }

            Console.WriteLine("User validation successful.");
            return true;
        }
    }
}
