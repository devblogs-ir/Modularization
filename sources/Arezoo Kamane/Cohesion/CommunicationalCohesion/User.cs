using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesion.CommunicationalCohesion
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return $"User: {Name}, Age: {Age}, Gender: {Gender}";
        }
    }
}
