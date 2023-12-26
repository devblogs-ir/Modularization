
namespace Coupling.DataCoupling
{
    public class UserController
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            this._userService = userService;
        }

        public void PrintUser(int userId)
        {
            UserDto? user = _userService.GetUserById(userId);

            if (user != null)
            {
                Console.WriteLine(user);
            }
            else
            {
                Console.WriteLine($"User with ID {userId} not found.");
            }
        }

        public void PrintAllUser()
        {
            List<UserDto> allUsers = _userService.GetAllUsers();

            Console.WriteLine("All Users:");
            foreach (var user in allUsers)
            {
                Console.WriteLine(user);
            }
        }

    }
}
