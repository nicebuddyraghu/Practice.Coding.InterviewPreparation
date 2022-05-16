namespace Practices.Programming.SolidPrinciples.OpenClosedPrinciple
{
    public class TaxCalculator : ITaxCalculator
    {
        public decimal CalculateTax(ICountryTaxCalculator countryTaxCalculator)
        {
            return countryTaxCalculator.CalculateTax();
        }
    }
}
