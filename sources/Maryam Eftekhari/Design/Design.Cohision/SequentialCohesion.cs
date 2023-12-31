using Design.Coupling;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Design.Cohesion
{
    /// <summary>
    /// کنترلر سند مالی
    /// </summary>
    public class VouchersController : ControllerBase
    {
        // Post Operation divided to multiple function
        [HttpPost]
        public IActionResult PostVoucher(Voucher voucher)
        {
            var validation = BasicValidation(voucher);
            if(validation is not OkResult) 
            {
                return BadRequest(validation);
            }

            validation = VoucherValidation(voucher);
            if (validation is not OkResult)
            {
                return BadRequest(validation);
            }

            var result = InsertVoucher(voucher);
            return StatusCode(StatusCodes.Status201Created, voucher);
        }

        public IActionResult BasicValidation(Voucher voucher)
        {
            //Do basic validation
            return Ok();
        }

        public IActionResult VoucherValidation(Voucher voucher) 
        {
            //Do voucher validation
            return Ok();        
        }

        public Voucher InsertVoucher(Voucher voucher) 
        {
            //Do voucher Insert in database
            return voucher;
        }
    }
}