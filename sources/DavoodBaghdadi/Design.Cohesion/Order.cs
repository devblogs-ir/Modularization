using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion
{
    public  class Order
    {
        public int CustomerId { get; set; }
        public bool IsSuccessfull { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
