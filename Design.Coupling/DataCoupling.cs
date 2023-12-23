
using Dumpify;

namespace Design.Coupling;
public class DataCoupling
{
    public void Main()
    {
        Context _context = new();
        UserRepository _userRepository = new UserRepository(_context);
        _userRepository.GetUser().Dump();
    }
}
public class Context
{
    public string GetUserName()
    {
        DataCouplingUser user = new();
        return user.Name;
    }
}
public class UserRepository
{
    private readonly Context _contexct;
    public UserRepository(Context context)
    {
        _contexct = context;
    }
    public string GetUser()
    {
        return _contexct.GetUserName();
    }
}

public class DataCouplingUser
{
    public string Name { get; set; }
}

