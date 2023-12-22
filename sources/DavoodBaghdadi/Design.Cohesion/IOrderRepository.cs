using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion
{
    public interface IOrderRepository
    {
        public IEnumerable<Order> GetAllOrders();
        public Order CreateOrder(int customerId);
        
    }
}
