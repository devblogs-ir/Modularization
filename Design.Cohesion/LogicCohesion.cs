
using Dumpify;

namespace Design.Cohesion;
public class LogicCohesion
{
    public void Main()
    {
        UserCRUDRepository userCRUDRepository = new UserCRUDRepository();
        User user = new() { Name="Arvin",PhoneNum = "09123456677" };
        userCRUDRepository.CreateUser(user);
        userCRUDRepository.DeleteUser(user);
        userCRUDRepository.UpdateUser(user);
        userCRUDRepository.GetUser(user);

    }
}
public class UserCRUDRepository
{
    public void CreateUser(User model)
    {
        $"{model.Name} Created".Dump();
    }
    public void UpdateUser(User model)
    {
        $"{model.Name} Updated".Dump();
    }
    public void DeleteUser(User model)
    {
        $"{model.Name} Deleted".Dump();
    }
    public void GetUser(User model)
    {
        $"{model.Name}".Dump();
    }
}

