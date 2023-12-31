using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Coupling
{
    public class UserRepository
    {
        public IEnumerable<User> GetEnebaledUsers()
        {
            IEnumerable<User> allUsers = new List<User>();
            return allUsers.Where(u => u.IsEnabled);
        }
    }
    public class ContentCoupling
    {
        public void ContentCoupledMethod()
        {
            var targetUsers = new UserRepository().GetEnebaledUsers();
            foreach (var user in targetUsers)
            {
                //Do something
            }
        }
    }
}
