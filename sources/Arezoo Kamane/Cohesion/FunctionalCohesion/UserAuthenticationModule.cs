namespace Cohesion.FunctionalCohesion
{
    public class UserAuthenticationModule
    {
        private bool ValidateUsernameFormat(string username)
        {
            return !string.IsNullOrEmpty(username) && username.Length >= 5;
        }

        private bool ValidatePasswordComplexity(string password)
        {
            return !string.IsNullOrEmpty(password) && password.Length >= 8;
        }

        public bool AuthenticateUser(string username, string password)
        {
            if (ValidateUsernameFormat(username) && ValidatePasswordComplexity(password))
            {
                Console.WriteLine($"User {username} authenticated successfully.");
                return true;
            }
            else
            {
                Console.WriteLine($"Authentication failed for user {username}.");
                return false;
            }
        }
    }
}
