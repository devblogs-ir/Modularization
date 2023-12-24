

namespace Coupling.DataCoupling
{
    public class UserService
    {
        private readonly List<UserDto> users; 

        public UserService()
        {
            users = new List<UserDto>
            {
                new UserDto { UserId = 1, UserName = "arezoo", Email = "arezoo@example.com" },
            };
        }

        public UserDto? GetUserById(int userId)
        {
            return users.Find(user => user.UserId == userId);
        }

        public List<UserDto> GetAllUsers()
        {
            return users;
        }
    }
}
