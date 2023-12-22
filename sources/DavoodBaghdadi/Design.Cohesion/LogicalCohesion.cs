using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion
{
    public  class LogicalCohesion: SequentialCohesion
    {
        ICustomerRepository _customerRepository;

        IOrderRepository _orderRepository;

       /// <summary>
       /// Create Order based on mobile number
       /// </summary>
       
        public Order CreateOrderForMobileNumber(string mobile)
        {
            if (IsCustomerAvilable(mobile))
            {
                var customerId = HasUnSuccessfullOrder(mobile);
                if (customerId != 0)
                    return GetLastUnsuccessOrder(customerId);
                return _orderRepository.CreateOrder(customerId);

            }
            else
            {
                _customerRepository.CreateCustomer(mobile);

               return CreateOrderForNewCustomer(mobile);
            }
        }
        public bool IsCustomerAvilable(string mobile)
        {
            return _customerRepository.GetAllCustomers().Any(c => c.Mobile == mobile);
        }
        Order CreateOrderForNewCustomer(string mobile)
        {
            var customer = _customerRepository.CreateCustomer(mobile);

            return _orderRepository.CreateOrder(customer.Id);
        }
       
    }
}
