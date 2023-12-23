namespace Shirin.Alizadeh.Design.Cupling;
using System;


interface IDataService
{
    void FetchData();
}


class DatabaseService : IDataService
{
    public void FetchData()
    {
        Console.WriteLine("Fetching data from the database");
    }
}


class APIService : IDataService
{
    public void FetchData()
    {
        Console.WriteLine("Fetching data from the API");
    }
}


class NoDirectProcessor
{
    private readonly IDataService dataService;

   
    public DataProcessor(IDataService dataService)
    {
        this.dataService = dataService;
    }

    public void ProcessData()
    {
        
        Console.WriteLine("Processing data...");

      
        dataService.FetchData();

    
    }
}


class Program
{
    static void Main()
    {
     
        DataProcessor processor1 = new NoDirectProcessor(new DatabaseService());
        processor1.ProcessData();

      
        DataProcessor processor2 = new NoDirectProcessor(new APIService());
        processor2.ProcessData();
    }


}
