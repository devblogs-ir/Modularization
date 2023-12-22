using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling.ExternalCoupling
{
    public class OrderService
    {
        private UserService _userService;
        private SomeExternalService _externalService;
        public OrderService(UserService userService, SomeExternalService externalService)
        {
            _userService = userService;
            _externalService = externalService;
        }

        
        public Order GetSpecialOrders(int someValue)
        {
            var user = _userService.GetUserWithSomeSpecification();
            if (someValue > _externalService.GetAValue())
                return new Order { Id = someValue, User = user };
            else return null;
        }


    }

    public class UserService
    {
        private SomeExternalService _externalService;

        public UserService(SomeExternalService externalService)
        {
            _externalService = externalService;
        }
        public User GetUserById(int userId)
        {
            return new User() { Id = 1 };
        }

        public User GetUserWithSomeSpecification()
        {
            return new User() { Id = _externalService.GetAValue() };
        }
        
    }

    public class SomeExternalService
    {
        public int GetAValue()
        {
            return 1;
        }
    }
}
