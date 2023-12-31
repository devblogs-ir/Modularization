
using Dumpify;

namespace Design.Cohesion;
public class FunctionCohesion
{
    private AccountRepository _accountRepository = new();
    User user = new() { Name = "user" ,PhoneNum = "09123456677"};
    public void Main()
    {
        _accountRepository.CreateUser(user).Dump();
        _accountRepository.UpdateUser(user).Dump();
        _accountRepository.DeleteUser(user).Dump();
    }
}

public class AccountRepository
{
    public string CreateUser(User user)
    {
        return $"{user} created";
    }
    public string UpdateUser(User user)
    {
        return $"{user} updated";
    }
    public string DeleteUser(User user)
    {
        return $"{user} deleted";
    }
}