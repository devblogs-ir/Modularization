namespace Coupling.CommonCoupling
{
    public class UserRepository
    {
        private static List<User> _users = new List<User>();

        public static void AddUser(User user)
        {
            _users.Add(user);
        }

        public static User GetUserById(int userId)
        {
            return _users.Find(user => user.UserId == userId);
        }

        public static List<User> GetAllUsers()
        {
            return new List<User>(_users);
        }
    }
}
