
using Dumpify;

namespace Design.Cohesion;
public class CommunicationCohesion
{
    public void Main()
    {
        UserRepository userRepository = new UserRepository();
        User user = new() { Name = "Arvin", PhoneNum = "09123456677" };
        userRepository.CreateUser(user);
    }
}

public class User
{
    public string Name { get; set; }
    public string PhoneNum { get; set; }
}
public class SMSProvider
{
    public void SendRegisterCode(User user,int registerCode)
    {
        $"{user.Name} your code is {registerCode}".Dump();
    }
}

public class UserRepository
{
    private SMSProvider smsProvider;
    public UserRepository()
    {
        smsProvider = new SMSProvider();
    }
    public void CreateUser(User user)
    {
        "send register code".Dump();
        smsProvider.SendRegisterCode(user, 1234);
    }

}