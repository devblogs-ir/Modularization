using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Coupling
{
    public class ControlCoupling
    {
        public void TotallyCoupled(UserDTO userDTO)
        {
            if (userDTO.IsEnabled)
            {
                //do Something
            }

            else
            {
                //Do something els
            }
        }

        //Better Practice For Control Coupling

        public void CreateUserWhenEnabled(UserDTO userDTO)
        {
            //do Something
        }
        public void CreateUserWhenDisabled(UserDTO userDTO)
        {
            //do Something
        }
    }
}
