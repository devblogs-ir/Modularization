using Dumpify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Design.Cohesion.SequencialCohesion.Customer;

namespace Design.Cohesion.SequencialCohesion
{
    public class Customer
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int LoyaltyPoint { get; set; }

        public void CalculateCustomerPoint()
        {
            "Calculate customer point based on earned and spent points".Dump();
        }
        public void CustomerGrade()
        {
            "return customer grade based on calculated point".Dump();
        }
    }
}
