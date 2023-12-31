
namespace Design.Coupling;
public class InteractionCoupling
{
    public void Main()
    {
        AccountManager accountManager = new AccountManager();
        accountManager.Login();
    }
}

public class Notification
{
    public string SendNotification(string state)
    {
        return $"your Login is {state}";
    }
}

public class AccountManager
{
    Notification notification;
    public AccountManager()
    {
        notification = new Notification();
    }
    public void Login()
    {
        notification.SendNotification("Success");
    }
}