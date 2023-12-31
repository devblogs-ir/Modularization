namespace Design.Cohesion.SequentialCohesion;

/// <summary>
/// Sequential Cohesion: An element outputs some data that becomes the input for other element, i.e., data flow between the parts.
/// Data pipelines are used to move data from one system to another, often with transformations along the way.
/// This class demonstrate the LoginPipeline which is a sample of sequential cohesion.
/// </summary>
public class SequentialCohesion
{
    public void Login(string username, string password)
    {
        try
        {
            if (ValidateCredentials(username, password))
            {
                GrantAccess(username);
            }
            else
            {
                throw new Exception("Invalid credentials");
            }
        }
        catch (Exception ex)
        {
            LogError(ex.Message);
        }
    }

    private bool ValidateCredentials(string username, string password)
    {
        // Validate credentials logic
        return true;
    }

    private void GrantAccess(string username)
    {
        // Grant access logic
        Console.WriteLine("Access granted for user: " + username);
    }

    private void LogError(string message)
    {
        // Log error logic
        Console.WriteLine("Error: " + message);
    }
}

