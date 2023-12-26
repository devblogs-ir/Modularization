namespace Coupling.CommonCoupling
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"User Information - ID: {UserId}, Name: {UserName}, Email: {Email}";
        }
    }
}
