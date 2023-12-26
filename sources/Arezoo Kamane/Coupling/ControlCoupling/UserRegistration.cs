namespace Coupling.ControlCoupling
{
    public class UserRegistration
    {
        private IUserRegistrationStrategy _registrationStrategy;

        public void SetRegistrationStrategy(IUserRegistrationStrategy strategy)
        {
            this._registrationStrategy = strategy;
        }

        public void ProcessRegistration(string userName)
        {
            if (_registrationStrategy == null)
            {
                Console.WriteLine("No registration strategy set. Cannot process registration.");
                return;
            }

            _registrationStrategy.RegisterUser(userName);
        }
    }
}

