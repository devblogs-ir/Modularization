using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling.ControlCoupling
{
    public class OrderService
    {
        private UserService _userService;
        public OrderService(UserService userService)
        {
            _userService = userService;
        }

        public void GetSomeOrders()
        {
            if (_userService.IsUserPermium(10))
            {
                // do something
            }
            else
            {
                //do something else
            }
        }


    }

    public class UserService()
    {
        public User GetUserById(int userId)
        {
            return new User() { Id = 1 };
        }

        public bool IsUserPermium(int userId)
        {
            return false;
        }
    }
}
