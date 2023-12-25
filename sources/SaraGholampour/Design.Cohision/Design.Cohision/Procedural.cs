namespace Design.Cohesion;

public class User
{
    public string Name { get; set; }
    public DateOnly BirthDate { get; set; }
    public string NationalCode { get; set; }
    public Guid? Id { get; set; }

    public User(string name, DateOnly birthDate, string nationalCode)
    {
        Name = name;
        BirthDate = birthDate;
        NationalCode = nationalCode;
    }
}

public class Procedural
{
    public User[] GetUsers()
    {
        User[] users =
        {
            new User("sara", new DateOnly(), "234234")
        };

        return users;
    }

    public void GenerateIdForUsers(User[] users)
    {
        foreach (var user in users)
        {
            user.Id = new Guid();
        }
    }

    public void SendMessage()
    {
        User[] newUsers = GetUsers();
        GenerateIdForUsers(newUsers);

        foreach (var user in newUsers)
        {
            Console.WriteLine($"send messsage to {user.Name}");
        }
    }
}
