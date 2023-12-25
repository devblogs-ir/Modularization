

namespace Coupling.DataCoupling
{
    public class UserService
    {
        private readonly List<UserDto> _users;

        public UserService()
        {
            _users = new List<UserDto>
            {
                new UserDto { UserId = 1, UserName = "arezoo", Email = "arezoo@example.com" },
            };
        }

        public UserDto? GetUserById(int userId)
        {
            return _users.Find(user => user.UserId == userId);
        }

        public List<UserDto> GetAllUsers()
        {
            return _users;
        }
    }
}
