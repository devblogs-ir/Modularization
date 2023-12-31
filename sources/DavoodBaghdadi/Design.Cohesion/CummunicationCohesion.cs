using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion
{
    public  class CummunicationCohesion
    {
        IOrderRepository _orderRepository;

        public int GetSuccessfullOrder()
        {
            return _orderRepository.GetAllOrders().Where(o => o.IsSuccessfull).Count();
        }
        public int GetUnsuccessfullOrders()
        {
            return _orderRepository.GetAllOrders().Where(o => !o.IsSuccessfull).Count();
        }
    }
}
