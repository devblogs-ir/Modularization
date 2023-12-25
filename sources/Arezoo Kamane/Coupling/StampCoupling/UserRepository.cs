namespace Coupling.StampCoupling
{

    public record UserRecord(string UserName, string Email, DateTime RegistrationDate);

    public class UserRepository
    {
        private readonly List<UserRecord> _users;

        public UserRepository()
        {
            _users = new();
        }

        public bool IsUserNameUnique(string userName)
        {
            return !_users.Any(user => user.UserName == userName);
        }

        public bool IsEmailUnique(string email)
        {
            return !_users.Any(user => user.Email == email);
        }

        public void AddUser(UserRecord user)
        {
            _users.Add(user);
        }
    }
}
