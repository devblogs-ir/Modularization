using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion
{
    public class Payment
    {
        public int Id { get; set; }
        public int No { get; set; }
        public bool Confirmed { get; set; }
        public bool Approved { get; set; }
    }
    public partial class PaymentService
    {
        public void ConfirmPayment(Payment payment)
        { 
        }

        public void ApprovePayment(Payment payment) 
        { 
        }

        public void UndoConfirm(Payment payment) 
        { 
        }

        public void UndoApprove(Payment payment) 
        { 
        }
    }
}
