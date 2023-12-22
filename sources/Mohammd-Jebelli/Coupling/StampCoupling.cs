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
        public OrderService(UserService userService)
        {
            _userService = userService;
        }

        public Order GetLastOrderByUser(GetUserDto userDto)
        {
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
