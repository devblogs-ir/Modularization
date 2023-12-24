namespace Design.Cohesion
{
    file class LoanFileProcess
    {
        public void CalculateLoan()
        {
            List<Payment> payments = new List<Payment>();
            var result = ProcessPayment(payments);
            int liability = 0;
            foreach (var item in result)
            {
               liability=  CalculateLiability(item);
            }
            
            var loan = CalculateLoan(liability);
        }

        private decimal CalculateLoan(int liability)
        {
            throw new NotImplementedException();
        }

        private int CalculateLiability(Payment payments)
        {
            throw new NotImplementedException();
        }

        private List<Payment> ProcessPayment(List<Payment> payments)
        {
            throw new NotImplementedException();
        }
    }

    file class Payment
    {
    }
}
