namespace Design.Cohesion.FunctionalCohesion;

/* 
    Description: 
    this is first File.
*/

public class Calculator
{
    public int Add(int x, int y) => x + y;
    
    public int Subtract(int x, int y) => x - y;
    
    public int Multiply(int x, int y) => x * y;
    
    public double Divide(int x, int y)
    {
        if (y == 0)
            throw new ArgumentException("zero is wrong!");

        return (double)x / y;
    }
}

/*
    Description: 
    this class including methods that related to a single purpose or functionality.
*/