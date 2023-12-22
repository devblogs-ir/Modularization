using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling.CommonCoupling
{
    public static class SharedData
    {
        public static int Value = 10;
    }
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
            if (someValue > SharedData.Value)
                return new Order { Id = someValue, User = user };
            else return null;
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
            return new User() { Id = SharedData.Value };
        }
        
    }

}
