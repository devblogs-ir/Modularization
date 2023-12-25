namespace Design.Cohesion;

public class Coincidental
{
    public void PrintMessage(string message)
    {
        Console.Write(message);
    }

    public int GetRandomNumber()

    {
        Random rand = new();
        return rand.Next();
    }

    public DateOnly GetToday()
    {
        return new DateOnly();
    }

    public bool ValidateUser()
    {
        return false;}
    public void GetUser(){}
}
