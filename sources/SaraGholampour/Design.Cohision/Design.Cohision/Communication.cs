namespace Design.Cohesion;

public class Communication
{
    public User[] HandleId(User[] users)
    {
        User[] newUsers = users;
        foreach (var user in newUsers)
        {
            user.Id = new Guid();
        }

        return newUsers;
    }

    public User[] GetYoungUsers(User[] users)
    {
        User[] newUsers = users.Where(user => user.BirthDate.Year - new DateTime().Year < 25).ToArray();


        return newUsers;
    }
}
