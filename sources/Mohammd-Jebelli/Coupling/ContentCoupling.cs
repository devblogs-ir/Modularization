using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling.ContentCoupling
{

    public class OrderService
    {
        private UserService _userService;

        public OrderService(UserService userService)
        {
            _userService = userService;
        }


        public Order GetSpecialOrders(int someValue)
        {
            var user = _userService.GetUserWithSomeSpecification();
            return new Order { Id = someValue, User = user };
        }


    }

    public class UserService
    {

        public UserService()
        {
        }
        public User GetUserById(int userId)
        {
            return new User() { Id = 1 };
        }

        public User GetUserWithSomeSpecification()
        {
            return new User() { Id = 10 };
        }

    }

}
