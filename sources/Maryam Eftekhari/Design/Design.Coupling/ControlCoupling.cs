using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Coupling
{
    public partial class Check
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public byte Status { get; set; }
        public string? Description { get; set; }
    }

    public enum CheckStatus
    {
        /// <summary>
        /// وصول نشده
        /// </summary>
        NotClearing = 0,

        /// <summary>
        /// وصول شده
        /// </summary>
        Clearing = 1,

        /// <summary>
        /// در جریان وصول
        /// </summary>
        Floating = 2,

        /// <summary>
        /// برگشتی
        /// </summary>
        Bounced = 3,
    }

    public class CheckService
    {
        //All operations collected to this method and possible  missing some of statuses
        public void RegisterCheckOperation (Check check)
        {
            var status = (CheckStatus)check.Status; 
            switch(status) 
            {
                case CheckStatus.NotClearing:
                    //Do not clearing check
                    break;
                case CheckStatus.Clearing:
                    //Do clearing check
                    break;
                case CheckStatus.Floating:
                    //Do not floating check
                    break;
                case CheckStatus.Bounced:
                    //Do bounced check
                    break;
            }
        }
    }
}
