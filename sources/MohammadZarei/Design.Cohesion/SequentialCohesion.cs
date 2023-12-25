namespace Design.Cohesion
{
    public sealed class SequentialWorkflow
    {
        public void Run()
        {
            var data = GetData();
            var processedData = ProcessOnData(data);
            Dispaly(processedData);
        }

        private List<string> GetData()
        {
            return new List<string>() 
            {
                "first item",
                "second item",
                "third item"
            };
        }

        private List<string> ProcessOnData(List<string> data)
        {
            return data.ConvertAll(item => item.ToUpper());
        }

        private void Dispaly(List<string> processedData)
        {
            foreach (var data in processedData)
            {
                Console.WriteLine(data);
            }
        }
    }
}
