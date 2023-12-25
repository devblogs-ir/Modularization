
namespace Coupling.DataCoupling
{
    public class UserController
    {
        private readonly UserService userService;

        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        public void PrintUser(int userId)
        {
            UserDto? user = userService.GetUserById(userId);

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
            List<UserDto> allUsers = userService.GetAllUsers();

            Console.WriteLine("All Users:");
            foreach (var user in allUsers)
            {
                Console.WriteLine(user);
            }
        }

    }
}
