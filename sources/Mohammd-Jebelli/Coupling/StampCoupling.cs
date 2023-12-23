using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling.StampCoupling
{
    public class OrderService
    {
        private UserService _userService;
        public OrderService()
        {
            
        }

        public Order GetLastOrderByUser()
        {
            var userDto = new GetUserDto() { Id = 1 };
            
            //changes in userDto structure can cause runtime errors
            var user = _userService.GetUserById(userDto);

            return new Order { Id = 100, User = user };
        }

    }
    public class GetUserDto
    {
        public int Id { get; set; }
    }
    public class UserService()
    {
        public User GetUserById(GetUserDto userDto)
        {
            return new User() { Id = userDto.Id };
        }
    }
}
