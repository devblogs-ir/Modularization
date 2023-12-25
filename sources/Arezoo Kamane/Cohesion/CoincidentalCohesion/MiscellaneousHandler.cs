namespace Cohesion.CoincidentalCohesion
{
    public class MiscellaneousHandler
    {
        private List<UserDto> _users;

        public MiscellaneousHandler()
        {
            _users = new List<UserDto>
            {
                new UserDto { UserId = 1, UserName = "johnDoe", Email = "john@example.com" },
            };
        }

        public UserDto GetUserById(int userId)
        {
            Console.WriteLine("Function 1: Get User by ID");
            var user = _users.Find(u => u.UserId == userId);

            return user;
        }

        public IEnumerable<UserDto> SearchUsersByName(string name)
        {
            Console.WriteLine("Function 2: Search Users by Name");
            var matchedUsers = _users.FindAll(u => u.UserName.Contains(name, StringComparison.OrdinalIgnoreCase));

            return matchedUsers;
        }

        public string GetSystemConfiguration()
        {
            Console.WriteLine("Function 3: Retrieve System Configuration");
            var systemConfig = "Configuration settings: ...";
            return systemConfig;
        }


    }
}
