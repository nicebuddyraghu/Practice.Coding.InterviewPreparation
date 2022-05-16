namespace Practices.Programming.SolidPrinciples.OpenClosedPrinciple
{
    public class TaxCalculatorCanada : ICountryTaxCalculator
    {
        private IncomeDetails income;
        public TaxCalculatorCanada(IncomeDetails incomeDetails)
        {
            income = incomeDetails;
        }

        public decimal CalculateTax()
        {
            decimal taxableIncome = income.TotalIncome - income.TotalDeduction;
            return taxableIncome * 30 / 100;
        }
    }
}
