namespace Design.Coupling
{
    public class Account
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int FiscalPeriodId { get; set; }
        public string? Description { get; set; }
    }

    public partial class AccountService
    {
        // Direct Coupling between Account class and IsAccountDateInFiscalPeriod method
        public bool IsAccountDateInFiscalPeriod(DateTime date, int fiscalPeriodId)
        {
            return true;
        }
    }
}