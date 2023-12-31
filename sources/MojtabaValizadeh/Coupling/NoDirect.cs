namespace Coupling;

public class NoDirect
{
    public interface ILogger
    {
        void Log(string message);
    }
    
    
    // Implement a specific logger
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
    
    
    
    // Calculator class with loose coupling to ILogger
    public class Calculator
    {
        private readonly ILogger _logger;

        // Constructor injection for ILogger
        public Calculator(ILogger logger)
        {
            this._logger = logger;
        }

        public int Add(int a, int b)
        {
            // Perform the calculation
            int result = a + b;

            // Log the result using the injected logger
            _logger.Log($"Adding {a} and {b} resulted in {result}");

            return result;
        }
    }
    /* Explain:
     In this example, Calculator is not directly coupled to a specific logging implementation. 
     Instead, it relies on the ILogger interface. This allows you to easily switch to a different 
     logging implementation without modifying the Calculator class. 
     
     */
}