namespace Coupling.ContentCoupling
{
    public class UserManager
    {
        private List<User> _users;

        public UserManager()
        {
            _users = new List<User>();
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void DisplayUsers()
        {
            foreach (var user in _users)
            {
                user.PrintUserInfo();
            }
        }
    }
}
