using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion
{
    public class SequentialCohesion
    {

        public IOrderRepository _orderRepository;

        public ICustomerRepository _customerRepository;


        public int HasUnSuccessfullOrder(string mobileNumber)
        {
            var customer = _customerRepository.GetAllCustomers().FirstOrDefault(c => c.Mobile == mobileNumber);
            var orders = _orderRepository.GetAllOrders();
            if (orders.Where(c => c.CustomerId == customer.Id).Count() > 0)
                return orders.LastOrDefault(o => o.IsSuccessfull == false).CustomerId;
            return 0;
        }
        public Order GetLastUnsuccessOrder(int customerId)
        {
            return _orderRepository.GetAllOrders().LastOrDefault(o => o.CustomerId == customerId);
        }
    }
}
