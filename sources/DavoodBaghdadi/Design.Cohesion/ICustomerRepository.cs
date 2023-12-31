using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion
{
    public interface ICustomerRepository
    {
        public IEnumerable<Customer> GetAllCustomers();
        public Customer CreateCustomer(string mobile);
        
    }
}
