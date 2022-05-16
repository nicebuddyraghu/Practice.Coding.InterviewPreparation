namespace Practices.Programming.SolidPrinciples.OpenClosedPrinciple
{
    public interface ITaxCalculator
    {
        decimal CalculateTax(ICountryTaxCalculator countryTaxCalculator);
    }
}
