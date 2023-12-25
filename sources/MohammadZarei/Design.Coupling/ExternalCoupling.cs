namespace Design.Coupling
{
    public sealed class User
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required string PhoneNumber { get; set; }
    }

    public sealed class SMSService
    {
        public bool Send(string phoneNumber, string message)
        {
            Console.WriteLine($"Sending SMS: {message} to {phoneNumber}");

            return true;
        }
    }

    public sealed class UserService
    {
        private readonly SMSService _smsService;

        public UserService(SMSService smsService)
        {
            _smsService = smsService;
        }

        public void Register(User user)
        {
            // registering user with username and hashed password
            var registerationResult = true;

            if (!registerationResult)
            {
                Console.WriteLine("registeration failed!");
                return;
            }

            if (!_smsService.Send(user.PhoneNumber, "Registeration Done!"))
            {
                Console.WriteLine("Faild to send SMS!");
                return;
            }

            Console.WriteLine("Registeration done and SMS sent successfully");
        }
    }
}
