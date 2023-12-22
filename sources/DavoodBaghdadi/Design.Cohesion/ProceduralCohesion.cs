using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion
{
    public class ProceduralCohesion : SequentialCohesion
    {
        //Notify Customers with Unsuccessfull orders

        INotifyCustomer _notifyCustomer;

        public void NotifyUnSuccessfullOrder()
        {
            var uno = GetUnsuccessfullOrders();
            var customers = GetCustomerWithUnsuccessfullOrder(uno);
            foreach (var c in customers)
            {
                _notifyCustomer.SendUnCompeleteOrderSMS(c.Mobile);
            }
        }

        public IEnumerable<Order> GetUnsuccessfullOrders()
        {
            return _orderRepository.GetAllOrders().Where(o => o.IsSuccessfull is false);
        }

        public IEnumerable<Customer> GetCustomerWithUnsuccessfullOrder(IEnumerable<Order> unsuccessOrders)
        {
            return unsuccessOrders.Select(o => new Customer { Id = o.CustomerId });
        }

        
    }
}
