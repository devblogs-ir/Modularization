using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling.NoDirectCoupling
{
    public class OrderService
    {
        public Order GetOrder(int orderId)
        {
            return new Order() { Id = orderId, User = new User() {  Id =1,UserName ="some username"} };
        }
    }
    public class UserService
    {
        public User GetUser(int userId) 
        {
            return new User() { Id = userId, UserName = "some username" };
        }
    }
}
