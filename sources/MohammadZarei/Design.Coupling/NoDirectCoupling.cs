namespace Design.Coupling
{
    public interface IMessageService
    {
        void SendMessage(string message);
    }

    public sealed class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }

    public sealed class NotificationManager
    {
        private readonly IMessageService _messageService;

        public NotificationManager(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Send(string notification)
        {
            _messageService.SendMessage(notification);
        }
    }
}
