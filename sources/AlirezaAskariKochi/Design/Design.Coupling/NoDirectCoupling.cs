using static Design.Coupling.NoDirectCoupling;

namespace Design.Coupling
{
    public class NoDirectCoupling
    {
        private Database _db;

        public NoDirectCoupling(Database db)
        {
           _db = db;
        }
        public void MethodA()
        {
            var modelA = new Model() { Id = 1, Name = "test" };
            _db.Create(modelA);
        }
        public void MethodB()
        {
            var modelB = new Model() { Id = 1, Name = "Updated test" };
            _db.Update(modelB);
        }         
    }
    public class Database
    {
        public void Create(Model model)
        {
            Console.WriteLine($"Create Model Name = {model.Name} and Id ={model.Id}");
        }
        public void Update(Model model)
        {
            Console.WriteLine($"Update Name of Model with Id ={model.Id} to Name = {model.Name}");
        }
    }

    public class Model
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}