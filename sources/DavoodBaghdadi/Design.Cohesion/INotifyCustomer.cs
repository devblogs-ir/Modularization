using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion
{
    public  interface INotifyCustomer
    {
        public void SendUnCompeleteOrderSMS(string phoneNumber);
        public void SendDiscountCode(string phoneNumber);
    }
}
