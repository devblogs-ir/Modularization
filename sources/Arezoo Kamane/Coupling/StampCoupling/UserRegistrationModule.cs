namespace Coupling.StampCoupling
{
    public class UserRegistrationModule
    {

        private readonly UserRepository userRepository;

        public UserRegistrationModule(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void RegisterUser(UserRecord user)
        {
            Console.WriteLine($"Registering user - UserName: {user.UserName}, Email: {user.Email}, Registration Date: {user.RegistrationDate}");

            userRepository.AddUser(user);

            Console.WriteLine("User registration successful.");
        }

    }
}
