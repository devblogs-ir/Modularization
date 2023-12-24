namespace Design.Cohesion
{
    file class LoanFileProcess
    {
        public void CalculateLoan()
        {
            List<Payment> payments = new List<Payment>();
            var result = ProcessPayment(payments);
            var liability = CalculateLiability(payments);
            var loan = CalculateLoan(payments);
        }

        private List<Payment> CalculateLoan(List<Payment> liability)
        {
            throw new NotImplementedException();
        }

        private List<Payment> CalculateLiability(List<Payment> payments)
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
