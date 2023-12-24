using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Coupling
{
    public class StampCoupling
    {
        public class Voucher
        {
            public Voucher()
            {
                CreatedDate = DateTime.Now;
                Description = string.Empty;
            }

            public int Id { get; set; }
            public DateTime CreatedDate { get; set; }
            //ModifiedDate added after a while and missing in constructor.
            //So CreateAutomaticVoucher return incomplete Data
            public DateTime ModifiedDate { get; set; }
            public string Description { get; set; }
        }

        public class VoucherService
        {
            public Voucher CreateAutomaticVoucher()
            {
                Voucher voucher = new Voucher();
                return voucher;
            }
        }
    }
}
