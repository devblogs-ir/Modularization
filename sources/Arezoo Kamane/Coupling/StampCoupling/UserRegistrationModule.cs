namespace Coupling.StampCoupling
{
    public class UserRegistrationModule
    {

        private readonly UserRepository _userRepository;

        public UserRegistrationModule(UserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public void RegisterUser(UserRecord user)
        {
            Console.WriteLine($"Registering user - UserName: {user.UserName}, Email: {user.Email}, Registration Date: {user.RegistrationDate}");

            _userRepository.AddUser(user);

            Console.WriteLine("User registration successful.");
        }

    }
}
