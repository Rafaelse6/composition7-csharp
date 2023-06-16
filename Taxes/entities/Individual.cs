namespace Taxes.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anuallIncome, double healthExpenditures) : base(name, anuallIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double firstIncomeCase = AnuallIncome * 15 / 100;
            double secondIncomeCase = AnuallIncome * 25 / 100;
            double healthExpendituresCase = HealthExpenditures * 0.5;

            if (AnuallIncome <= 20.000)
            {
                return firstIncomeCase - healthExpendituresCase;
            }
            else
            {
                return secondIncomeCase - healthExpendituresCase;
            }
        }
    }
}