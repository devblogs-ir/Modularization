using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Coupling
{
    public class DirectCoupling
    {
        /// <summary>
        /// Data Object Model has Direct Coupled and It may some data lost.
        /// </summary>
        public void CreateUser()
        {

            var service = new UserService();

            var userDto = new UserDTO() { Name = "name" };

            service.Create(GetUser(userDto));

        }
        public User GetUser(UserDTO userDTO)
        {
            return new User()
            {
                Name = userDTO.Name,
                LastName = userDTO.LastName,
                Id = userDTO.Id
            };
        }
    }
}
