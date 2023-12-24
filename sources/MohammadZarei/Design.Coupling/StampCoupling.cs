namespace Design.Coupling
{
    public sealed class Message
    {
        public string Sender { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }
    }

    public sealed class MessageSenderService
    {
        public Message Send(string sender, string content)
        {
            var message = new Message
            {
                Content = content,
                TimeStamp = DateTime.UtcNow,
                Sender = sender,
            };

            Console.WriteLine($"Sending message from {message.Sender} at {message.TimeStamp} with content: {message.Content}");

            return message;
        }
    }

    public sealed class MessageReceiverService
    {
        public void Receive(Message message)
        {
            Console.WriteLine($"Receiving message at {message.TimeStamp} with content: {message.Content}");
        }
    }
}
