namespace Practices.Programming.SolidPrinciples.OpenClosedPrinciple
{
    public class TaxCalculatorIndia : ICountryTaxCalculator
    {
        private IncomeDetails income;
        public TaxCalculatorIndia(IncomeDetails incomeDetails)
        {
            income = incomeDetails;
        }

        public decimal CalculateTax()
        {
            decimal taxableIncome = income.TotalIncome - income.TotalDeduction;
            return taxableIncome * 20 / 100;
        }
    }
}
