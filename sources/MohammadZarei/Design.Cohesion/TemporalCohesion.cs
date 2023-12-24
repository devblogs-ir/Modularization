namespace Design.Cohesion
{
    public class InvoiceManager
    {
        public void ResetInvoiceNumber(DateTime currentDateTime)
        {
            if (currentDateTime.DayOfYear == 1)
            {
                // reset generating invoice number
            }
        }
    }
}
