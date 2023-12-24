namespace Cohesion;

interface ICommunication
{
    void SendMessage(string message);
    void ReceiveMessage();
}

class EmailCommunication : ICommunication
{
    public void SendMessage(string message)
    {
        // Code to send an email
    }

    public void ReceiveMessage()
    {
        // Code to receive an email
    }
}

class SmsCommunication : ICommunication
{
    public void SendMessage(string message)
    {
        // Code to send an SMS
    }

    public void ReceiveMessage()
    {
        // Code to receive an SMS
    }
}


// Define an interface that represents a communication contract and implement it in different classes.