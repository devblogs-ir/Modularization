namespace Shirin.Alizadeh.Design.Cupling;

using System;


class DataCouplingExample
{
  
  
   
    class DataProcessor
    {
        public void ProcessData(int Value1, string Value2, bool Value3) 
        {
         
            Console.WriteLine($"Processing data: {Value1}, {Value2},{Value3}");
        }
    }

    
   
}

public class  ProcessController(DataCouplingExample dataCoupling)
{

    private readonly DataCouplingExample _dataCoupling= dataCoupling;


   public void  processor (int Value1, string Value2, bool Value3)
    {
        _dataCoupling.ProcessData(Value1, Value2, Value3);  
    }


   
}

