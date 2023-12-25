namespace Cohesion.SequentialCohesion
{
    public class UserStateMachine
    {
        private UserState _currentState;

        public UserStateMachine()
        {
            _currentState = UserState.Registered;
        }

        public void VerifyEmail()
        {
            if (_currentState == UserState.Registered)
            {
                Console.WriteLine("Email verification successful.");
                _currentState = UserState.EmailVerified;
            }
            else
            {
                Console.WriteLine("Invalid state transition. Email verification can only be performed from 'Registered' state.");
            }
        }

        public void ActivateAccount()
        {
            if (_currentState == UserState.EmailVerified)
            {
                Console.WriteLine("Account activation successful. User is now active.");
                _currentState = UserState.Active;
            }
            else
            {
                Console.WriteLine("Invalid state transition. Account activation can only be performed from 'EmailVerified' state.");
            }
        }

        public UserState GetCurrentState()
        {
            return _currentState;
        }
    }
}
