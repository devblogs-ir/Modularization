
namespace Cohesion.CommunicationalCohesion
{
    public class UserFilteringModule
    {
        public List<User> FilterUsersByAge(List<User> users, int minAge, int maxAge)
        {
            return users.Where(user => user.Age >= minAge && user.Age <= maxAge).ToList();
        }

        public List<User> FilterUsersByGender(List<User> users, string gender)
        {
            return users.Where(user => user.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
