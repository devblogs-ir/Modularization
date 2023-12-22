using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling.DataCoupling
{

    public class OrderService
    {
        private UserService _userService;
        public OrderService(UserService userService)
        {
            _userService = userService;
        }

        public Order GetLastOrderByUser(int userId)
        {
            var user = _userService.GetUserById(userId);

            return new Order { Id = 100, User = user };
        }

    }
    public class UserService()
    {
        public User GetUserById(int id)
        {
            return new User() { Id = id };
        }
    }

}
