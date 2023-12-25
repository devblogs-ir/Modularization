namespace Coupling.ContentCoupling
{
    public class UserManager
    {
        private List<User> users;

        public UserManager()
        {
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void DisplayUsers()
        {
            foreach (var user in users)
            {
                user.PrintUserInfo();
            }
        }
    }
}
