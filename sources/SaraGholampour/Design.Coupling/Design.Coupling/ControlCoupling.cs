namespace Design.Coupling;

public class Company
{
    public User[] Employees { get; set; }
    public User[] Managers { get; set; }

    public void AddUserToCompany(User user, bool IsManager)
    {
        if (IsManager)
            Managers = [..Managers, user];

        else
            Employees = [..Employees, user];
    }
}

public class ControlCoupling
{
    public static void Main(string[] args)
    {
        Company DigiKala = new();
        DigiKala.AddUserToCompany(new User("sara",20,new DateOnly()),false);
    }
}
