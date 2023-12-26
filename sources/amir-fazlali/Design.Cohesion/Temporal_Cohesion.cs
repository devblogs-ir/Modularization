class Logger
{
    public void Log(string message)
    {
        try
        {
            // Log here to file
        }
        catch(IOException ex)
        {
            // When not enough disk exception occured
            AlertToAdmin();
            if(!Cleanup())
            {
                DisableProgram();
            }
        }
    }

    public bool Cleanup()
    {
        // logic here
        return false;
    }

    public void AlertToAdmin()
    {
        // logic here
    }

    public void DisableProgram()
    {
        // logic here
    }
}
