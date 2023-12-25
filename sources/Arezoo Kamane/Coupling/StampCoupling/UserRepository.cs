namespace Coupling.StampCoupling
{

    public record UserRecord(string UserName, string Email, DateTime RegistrationDate);

    public class UserRepository
    {
        private readonly List<UserRecord> users;

        public UserRepository()
        {
            users = new();
        }

        public bool IsUserNameUnique(string userName)
        {
            return !users.Any(user => user.UserName == userName);
        }

        public bool IsEmailUnique(string email)
        {
            return !users.Any(user => user.Email == email);
        }

        public void AddUser(UserRecord user)
        {
            users.Add(user);
        }
    }
}
