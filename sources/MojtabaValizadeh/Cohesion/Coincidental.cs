namespace Cohesion;

public class Coincidental
{
    // Method to convert meters to kilometers
    public double MetersToKilometers(double meters)
    {
        return meters / 1000;
    }

    // Method to validate a user's email address
    public bool ValidateEmail(string email)
    {
        // Implementation to validate email address
        // ...
        return true;
    }

    // Method to generate a random number
    public int GenerateRandomNumber()
    {
        Random random = new Random();
        return random.Next();
    }

    // Method to log a message to the console
    public void LogMessage(string message)
    {
        Console.WriteLine(message);
    }
}
/*Explain:
 In this example, the methods in the Coincidental class do not have a clear and meaningful relationship. 
 Converting meters to kilometers, validating an email address, generating a random number, 
 and logging a message are unrelated tasks. 
 */