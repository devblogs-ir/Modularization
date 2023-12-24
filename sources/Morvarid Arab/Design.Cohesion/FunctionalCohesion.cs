using Dumpify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion.FunctionalCohesion
{
    public class Warehouse 
    {
        private int _currentInventory;
        public int TransferedQuantity { get; set; }
        public int ReceivedQuantity { get; set; }

        public Warehouse(int beginingInventory) 
        {
            _currentInventory = beginingInventory;
        }


        public void IncreaseInventory(int Received)
        {
            _currentInventory += ReceivedQuantity;
        }
        public void DecreaseInventory(int transfered)
        {
            _currentInventory -= TransferedQuantity;
        }
    }

    public class Product
    {
        public required string ProductName { get; set; }
        public required int ProductId { get; set; }
        public int ProductPrice { get; set; }



        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            return products;
        }

        public void GetProductById (int id)
        {
            Console.WriteLine("Return product by Id");
        }
    }
}
