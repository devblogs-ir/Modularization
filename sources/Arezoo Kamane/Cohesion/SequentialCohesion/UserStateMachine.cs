using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesion.SequentialCohesion
{
    public class UserStateMachine
    {
        private UserState currentState;

        public UserStateMachine()
        {
            currentState = UserState.Registered;
        }

        public void VerifyEmail()
        {
            if (currentState == UserState.Registered)
            {
                Console.WriteLine("Email verification successful.");
                currentState = UserState.EmailVerified;
            }
            else
            {
                Console.WriteLine("Invalid state transition. Email verification can only be performed from 'Registered' state.");
            }
        }

        public void ActivateAccount()
        {
            if (currentState == UserState.EmailVerified)
            {
                Console.WriteLine("Account activation successful. User is now active.");
                currentState = UserState.Active;
            }
            else
            {
                Console.WriteLine("Invalid state transition. Account activation can only be performed from 'EmailVerified' state.");
            }
        }

        public UserState GetCurrentState()
        {
            return currentState;
        }
    }
}
