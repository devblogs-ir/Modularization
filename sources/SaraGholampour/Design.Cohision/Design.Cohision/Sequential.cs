namespace Design.Cohesion;

public class Sequential
{
    public bool ValidateUser(User user)
    {
        if (user.Id != null)
        {
            return true;
        }
        else return false;
    }

    public void GetUser(User users, bool isValid)
    {
        if (isValid)
        {
            Console.WriteLine("user is not valid");
        }
        else Console.WriteLine("user valid");
    }

    public void Handle()
    {
        User user = new User("ali", new DateOnly(), "i238748237");
        GetUser(user, ValidateUser(user));
    }
}
