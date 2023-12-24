namespace Design.Cohesion.CommunicationalCohesion;

/// <summary>
/// Communicational Cohesion: Communicational cohesion occurs when elements are grouped together in a module based on their interactions with a specific external system or module.
/// Here is an example that demonstrates communicational cohesion in a messaging system:
/// </summary>
public class CommunicationalCohesion
{
    private List<Message> messages = new();

    public void SendMessage(Message message)
    {
        // Send message logic
        messages.Add(message);
        Console.WriteLine("Message sent: " + message.Text);
    }

    public void ReceiveMessages()
    {
        // Receive messages logic
        foreach (Message message in messages)
        {
            Console.WriteLine("Message received: " + message.Text);
        }
    }
}

public class Message
{
    public string Text { get; set; }
}

