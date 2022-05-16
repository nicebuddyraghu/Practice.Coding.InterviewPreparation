namespace Practices.Programming.SolidPrinciples.OpenClosedPrinciple
{
    public class TaxCalculatorUSA : ICountryTaxCalculator
    {
        private IncomeDetails income;
        public TaxCalculatorUSA(IncomeDetails incomeDetails)
        {
            income = incomeDetails;
        }

        public decimal CalculateTax()
        {
            decimal taxableIncome = income.TotalIncome - income.TotalDeduction;
            return taxableIncome * 35 / 100;
        }
    }
}
