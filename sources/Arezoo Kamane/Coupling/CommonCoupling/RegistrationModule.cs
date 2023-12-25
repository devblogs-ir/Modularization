namespace Coupling.CommonCoupling
{
    public class RegistrationModule
    {
        public static void RegisterUser(string username, string email)
        {
            int userCount = UserRepository.GetAllUsers().Count;
            
            int nextUserId = userCount + 1;
            User newUser = new User { UserId = nextUserId, UserName = username, Email = email };
            UserRepository.AddUser(newUser);
            Console.WriteLine($"User registered: {newUser}");
        }
    }
}
