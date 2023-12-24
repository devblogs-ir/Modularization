using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion
{
    public partial class PaymentService
    {
        /// <summary>
        /// first confirm second approve and final register have to call
        /// </summary>
        /// <param name="payment"></param>
        public void AutomaticReigsterPayment(Payment payment)
        {
            Confirm(payment);
            Approve(payment);
            Register(payment);
        }

        public void Confirm(Payment payment) 
        { 
        }

        public void Approve(Payment payment) 
        { 
        }

        public void Register(Payment payment) 
        { 
        }
    }
}
