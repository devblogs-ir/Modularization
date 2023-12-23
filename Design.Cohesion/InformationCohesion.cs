
using Dumpify;

namespace Design.Cohesion;
public class InformationCohesion
{
    public void Main()
    {
        User user1 = new() { Name = "test", PhoneNum = "09123456677" };
        AccountManager accountManager = new AccountManager();
        accountManager.AddUser(user1);
        accountManager.ALlUsers();
    }
}
public class AccountManager
{
    private List<User> users;
    public AccountManager()
    {
        users = new List<User>();
    }
    public void AddUser(User user)
    {
        users.Add(user);
    }
    public void ALlUsers()
    {
        foreach (User user in users)
        {
            user.Dump();
        }
    }
}
