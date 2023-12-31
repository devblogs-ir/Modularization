using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Coupling
{
    public  class UserDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string LastName { get; set; }
        public bool  IsEnabled { get; set; }
    }
}
