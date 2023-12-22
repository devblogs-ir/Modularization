using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion
{
    /// <summary>
    /// When successfull Orders be greater than 500 welcome customer to loyalty club
    /// </summary>
    public class TemporalCohesion
    {
        IOrderRepository _orderRepository;
        ICustomerRepository _customerRepository;
        INotifyCustomer _notifyCustomer;

        public void CompeletePayment(Order order)
        {
            //Some Codes
            if (_orderRepository.GetAllOrders()
                .Where(o => o.CustomerId == order.CustomerId)
                .Count() > 500)
            {

                GenerateDiscountCode();
                _notifyCustomer.SendDiscountCode(_customerRepository.GetAllCustomers().FirstOrDefault(c => c.Id == order.CustomerId).Mobile);

            }
        }

        private string GenerateDiscountCode()
        {
            return "discount code";
        }
    }
}
