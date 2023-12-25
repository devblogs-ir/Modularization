namespace Design.Coupling;

public class User
{
    public string Name { get; set; }
    public byte Age { get; set; }
    public DateOnly BirthDate { get; set; }
    private Guid GuId { get; set; }

    public User(string name, byte age, DateOnly birthDate)
    {
        Name = name;
        Age = age;
        BirthDate = birthDate;
        GuId = Guid.NewGuid();
    }

    public void DeleteUser(User[] users, Guid id)
    {
        users = users.Where(user => user.GuId != id).ToArray();
    }

    public void UpdateUser(List<User> users, User newUser, Guid Id)
    {
        var index = users.FindIndex(user => user.GuId == Id);
        users[index] = newUser;
    }
}

public class NoDirectCoupling
{
    static void Main(string[] args)
    {
        
    }
}
