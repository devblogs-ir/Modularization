namespace Coupling.ContentCoupling
{
    public class AccessToUserModule
    {
        public void AccessToUser(UserManager userManager)
        {
            User newUser = new User("arezoo", "123456");
            userManager.DisplayUsers();
            userManager.AddUser(newUser);
            userManager.DisplayUsers();
        }
    }
}
