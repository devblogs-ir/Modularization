using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Coupling
{
    public class Voucher
    {
        public Voucher()
        {
            CreatedDate = DateTime.Now;
            Description = string.Empty;
        }

        public int Id { get; set; }
        //If no comment ModifiedDate required property enable error in CreateAutomaticVoucher method
        //public required DateTime ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Description { get; set; }
    }

    public partial class VoucherService
    {
        public Voucher CreateAutomaticVoucher()
        {
            Voucher voucher = new();
            return voucher;
        }
    }
}
