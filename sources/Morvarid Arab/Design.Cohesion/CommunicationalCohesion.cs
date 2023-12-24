using Dumpify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion.CommunicationalCohesion
{
    public class Member
    {
        public required string Name { get; set; }
        public required string MobileNumber { get; set; }
        public required string Email { get; set; }
        public int Point {  get; set; }
    }
    
    public class PointManagement
    {
        public void IncreasePoint(Member member, int point)
        {
            // increase member points
            Console.WriteLine("Dear ", member.Name, ", you have received ", point, "points");  
        }
    }
    public class MemberService
    {
        private PointManagement memberPoint;

        public MemberService() 
        {
            memberPoint = new PointManagement();
        }

        public void NewMemberRegister(Member newMember) 
        {
            // register the new member
            Console.WriteLine($"Member {newMember.Name}");

            // receive 100 points for registration
            memberPoint.IncreasePoint(newMember, 100);
        }

        public void MemberActivty(Member member)
        {
            // receive 20 points for each new activity
            memberPoint.IncreasePoint(member, 20);
        }
    }

}
