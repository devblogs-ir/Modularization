namespace Cohesion;

public class LogicalCohesion
{
    public decimal Sum(decimal a, decimal b)
    {
        return a + b;
    }

    public bool isFileExist(string fileName)
    {
        if (File.Exists(fileName))
            return true;
        else
            return false;
    }
}

// in this example our cohesion is not good, because we have some function that have not same logic