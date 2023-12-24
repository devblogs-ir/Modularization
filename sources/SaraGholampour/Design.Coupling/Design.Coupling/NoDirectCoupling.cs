namespace Design.Coupling;


public class User
{
    public string Name { get; set; }
    public byte Age { get; set; }
    private Guid GuId { get; set; }

    public User(string name, byte age)
    {
        Name = name;
        Age = age;
        GuId = Guid.NewGuid();
    }

    public void DeleteUser(User[] users, Guid id)
    {
        users = users.Where(user => user.GuId != id).ToArray();
    }
}

public class Product
{
    public string Title { get; set; }
    public uint Price { get; set; }
    public Guid GuId { get; set; }

    public Product(string title, uint price)
    {
        Title = title;
        Price = price;
        GuId = Guid.NewGuid();
    }
}

public class NoDirectCoupling
{
    public User[] AllUsers =
    {
        new User("sara", 20),
        new User("samira", 21),
        new User("zahra", 22),
    };

    public Product[] products =
    {
        new Product("pen", 12000)
    };
}

