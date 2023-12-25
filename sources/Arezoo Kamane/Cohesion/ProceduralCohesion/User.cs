﻿namespace Cohesion.ProceduralCohesion
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"User: {Username}, Email: {Email}";
        }
    }
}
