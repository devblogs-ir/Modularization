﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling.ControlCoupling
{
    public class UserRegistration
    {
        private IUserRegistrationStrategy registrationStrategy;

            public void SetRegistrationStrategy(IUserRegistrationStrategy strategy)
            {
                this.registrationStrategy = strategy;
            }

            public void ProcessRegistration(string userName)
            {
                if (registrationStrategy == null)
                {
                    Console.WriteLine("No registration strategy set. Cannot process registration.");
                    return;
                }

                registrationStrategy.RegisterUser(userName);
            }
        }
    }

