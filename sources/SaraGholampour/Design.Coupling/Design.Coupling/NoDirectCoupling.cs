namespace Design.Coupling;
public class User
{
    public string Name { get; set; }
    public byte Age { get; set; }
    public DateOnly BirthDate { get; set; }
    private Guid GuId { get; set; }

    public User(string name, byte age,DateOnly birthDate)
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
}

public class NoDirectCoupling
{
    
}
