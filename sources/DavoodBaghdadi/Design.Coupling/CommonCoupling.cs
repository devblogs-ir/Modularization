using Design.Cohesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Coupling
{
    public class CommonCoupling
    {
        IOrderRepository _orderRepository;
        public IEnumerable<Order> GetRecentUnSuccess(int recentDays)
        {
            return _orderRepository.GetAllOrders()
                .Where(o => o.OrderDate > (DateTime.Now - TimeSpan.FromDays(GlobalAppSetting.TimePeriod)));
        }
        public void AMethodCanChangeGlobalAppSetting()
        {
            //Code
            GlobalAppSetting.TimePeriod = 7;
            //Rest of the Code
        }
        public void CommonCouplledMethod()
        {
            var x = GlobalAppSetting.TimePeriod;
            //Use X when GlobalAppSetting.TimeDuration changed by MethodCanChangeGlobalAppSetting()

        }
    }

    public static class GlobalAppSetting
    {
        public static int TimePeriod { get; set; }
    }
}

