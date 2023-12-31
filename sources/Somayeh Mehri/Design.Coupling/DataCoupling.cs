namespace Design.Coupling
{
    internal class UserService
    {
        public void LoginUser(string email, string password)
        {
            
        }
    }

    internal class UserController
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        public void login(string username, string password)
        {
            //Data Coupling
            _userService.LoginUser(username, password);
        }
    }
}
