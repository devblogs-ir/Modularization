using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Coupling
{
    public partial class BasicService
    {
        // Change method content for special state is difficult
        // because method is protected and multiple call in all services
        protected void Finalize()
        { 
        }
    }

    public partial class AccountService : BasicService
    {

        public void InsertAccount(Account account)
        {
            // My Insert Code

            Finalize();
        }

        public void UpdateAccount(Account account)
        {
            // My Update code

            Finalize();
        }

        public void DeleteAccount(int id) 
        {
            // My Delete Code

            Finalize();
        }
    }

    public partial class VoucherService : BasicService
    {

        public void InsertVoucher(Voucher voucher)
        {
            // My Insert Code

            Finalize();
        }

        public void UpdateVoucher(Voucher voucher)
        {
            // My Update code

            Finalize();
        }

        public void DeleteVoucher(int id)
        {
            // My Delete Code

            Finalize();
        }
    }
}
