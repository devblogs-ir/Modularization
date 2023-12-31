using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion
{
    public class CheckAccount
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int ProjectId { get; set; }
        public int CheckId { get; set; }
        public Check Check { get; set; }
    }
    public class CheckAccountService
    {
        public void AggregateCheckAccounts(int checkId)
        {
            var checkAccounts = GetCheckAccounts(checkId);
            Aggregate(checkAccounts);
            DeleteUseLessCheckAccounts(checkAccounts);
        }

        private List<CheckAccount> GetCheckAccounts(int checkId) 
        {
            return new List<CheckAccount>();
        }

        private void Aggregate(IList<CheckAccount> checkAccounts) 
        { 
        }

        private void DeleteUseLessCheckAccounts(IList<CheckAccount> checkAccounts)
        { 
        }
    }
}
