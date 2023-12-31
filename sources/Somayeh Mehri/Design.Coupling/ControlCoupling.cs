using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Coupling
{
    class Customer
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsBanned { get; set; }
    }

    internal class WelcomeService
    {
        internal void WellcomeUser(Customer user)
        {
            if (user.IsBanned == true)
            {
                // banned
            }
            else
            {
                //login
            }
        }

    }

    internal class WellcomeController
    {
        private readonly WelcomeService _wellcomeService;
        internal WellcomeController(WelcomeService wellcomeService)
        {
            _wellcomeService = wellcomeService;
        }

        internal void Wellcome(Customer user)
        {
            user.IsBanned = true;
            _wellcomeService.WellcomeUser(user);
        }
    }
}
