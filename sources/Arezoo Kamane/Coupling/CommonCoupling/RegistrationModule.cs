namespace Coupling.CommonCoupling
{
    public class RegistrationModule
    {
        public static void RegisterUser(string username, string email)
        {
            int nextUserId = UserRepository.GetAllUsers().Count + 1;
            User newUser = new User { UserId = nextUserId, UserName = username, Email = email };
            UserRepository.AddUser(newUser);
            Console.WriteLine($"User registered: {newUser}");
        }
    }
}
