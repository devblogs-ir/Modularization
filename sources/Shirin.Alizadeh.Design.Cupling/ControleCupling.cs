namespace Shirin.Alizadeh.Design.Cupling;

using System;


class DataCouplingExample
{

    class DataClass
    {
        public int Value1;
        public string Value2;
   
    }


    class DataProcessor
    {
        public void GetDataOrDeleteData(DataClass data ,bool IsValid)
        {
            if(IsValid)
            {
                Console.WriteLine($"Processing data: {data.Value1},{data.Value2}");
            } 
            else
            {
                Console.WriteLine($"Delete Data: {data.Value1},{data.Value2}");
            }
       
        }

     
    }


    static void Main()
    {

        DataClass dataInstance = new DataClass
        {
            Value1 = 42,
            Value2 = "Hello, World!"
        };


        DataProcessor processor = new DataProcessor();


        processor.ProcessData(dataInstance,true);
 
    }
}
