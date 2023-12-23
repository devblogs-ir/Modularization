namespace Design.Coupling
{
    class User
    {
        public string LoginDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NationalCode { get; set; }
    }

    internal class LoginService
    {
        internal void LoginUser(User user)
        {
            //ToDo
            Console.WriteLine($"login with username{user.Email} and password {user.Password}");
        }

    }

    internal class LoginController
    {
        private readonly LoginService _loginService;
        internal LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }

        internal void login(User user)
        {

            _loginService.LoginUser(user);
        }
    }
}
