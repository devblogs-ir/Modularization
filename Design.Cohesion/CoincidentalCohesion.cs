
using Dumpify;

namespace Design.Cohesion;

public class CoincidentalCohesion
{
    public void Main()
    {
        AllMethods methods = new AllMethods();
        methods.SendNotification();
        methods.CreateUser();
        methods.Login();
    }
}

public class AllMethods
{
    public void SendNotification()
    {
        "this is notification".Dump();
    }
    public void Login()
    {
        "Login".Dump();
    }
    public void CreateUser()
    {
        "User Created".Dump();
    }
}