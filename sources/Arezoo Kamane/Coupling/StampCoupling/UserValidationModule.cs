namespace Coupling.StampCoupling
{
    public class UserValidationModule
    {

        private readonly UserRepository _userRepository;

        public UserValidationModule(UserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public bool ValidateUser(UserRecord user)
        {
            Console.WriteLine($"Validating user - UserName: {user.UserName}, Email: {user.Email}");

            if (!_userRepository.IsUserNameUnique(user.UserName))
            {
                Console.WriteLine($"Username '{user.UserName}' is not unique. Validation failed.");
                return false;
            }

            if (!_userRepository.IsEmailUnique(user.Email))
            {
                Console.WriteLine($"Email '{user.Email}' is not unique. Validation failed.");
                return false;
            }

            Console.WriteLine("User validation successful.");
            return true;
        }
    }
}
