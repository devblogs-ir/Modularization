namespace Shirin.Alizadeh.Design.Cupling;

using System;


class DataCouplingExample
{

    class DataClass
    {
        public int Value1;
        public string Value2;
        public bool IsValid;
    }


    class DataProcessor
    {
        public void ProcessData(DataClass data)
        {

            Console.WriteLine($"Processing data: {data.Value1},{data.Value2},{data.IsValid}");
        }
        public void Log(DataClass data)
        {

            Console.WriteLine($"Processing Log Data: {data.IsValid}");
        }
    }


    static void Main()
    {

        DataClass dataInstance = new DataClass
        {
            Value1 = 42,
            Value2 = "Hello, World!",
            IsValid = false
        };


        DataProcessor processor = new DataProcessor();


        processor.ProcessData(dataInstance);
        processor.Log(dataInstance);  //stamp 
    }
}
