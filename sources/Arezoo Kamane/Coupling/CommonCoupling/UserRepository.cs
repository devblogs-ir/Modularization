namespace Coupling.CommonCoupling
{
    public class UserRepository
    {
        private static List<User> users = new List<User>();

        public static void AddUser(User user)
        {
            users.Add(user);
        }

        public static User GetUserById(int userId)
        {
            return users.Find(user => user.UserId == userId);
        }

        public static List<User> GetAllUsers()
        {
            return new List<User>(users);
        }
    }
}
