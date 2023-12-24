namespace Coupling;

class DatabaseConnection
{
    public void Connect()
    {
       
    }
    
    public void Disconnect()
    {
      
    }
}

class DataProcessor
{
    private DatabaseConnection dbConnection;
    
    public DataProcessor()
    {
        dbConnection = new DatabaseConnection();
    }
    
    public void ProcessData()
    {
        dbConnection.Connect();
        
        dbConnection.Disconnect();
    }
}

class ReportGenerator
{
    private DatabaseConnection dbConnection;
    
    public ReportGenerator()
    {
        dbConnection = new DatabaseConnection();
    }
    
    public void GenerateReport()
    {
        dbConnection.Connect();
        
        dbConnection.Disconnect();
    }
}

// in this example the DatabaseConnection class represents a global resource, and both class have a dependency on this source.
// any modify in global class, can affect both classes, so for resolve that we can use dependency injection 