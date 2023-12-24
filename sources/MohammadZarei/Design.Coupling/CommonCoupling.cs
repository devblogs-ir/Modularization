namespace Design.Coupling
{
    public sealed class CalculateTaxForFood
    {
        public decimal Calculate(decimal foodPrice)
        {
            return TaxRate.Rate * foodPrice;
        }
    }

    public sealed class CalculateTaxForCar
    {
        public decimal Calculate(decimal carPrice)
        {
            return TaxRate.Rate * carPrice;
        }
    }

    public sealed class TaxRateChanger
    {
        public void Change(decimal newTaxRate)
        {
            TaxRate.Rate = newTaxRate;
        }
    }

    public sealed class TaxRate
    {
        public static decimal Rate { get; set; } = 0.3m;
    }
}
