using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion
{
    public  class Customer
    {
        public int Id { get; set; }
        public double debit { get; set; }
        
        public double credit { get; set; }
        public string Mobile { get; set; }
    }
}
