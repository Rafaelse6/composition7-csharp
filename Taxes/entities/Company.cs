namespace Taxes.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company() { }

        public Company(string name, double anuallIncome, int numberOfEmployees) : base(name, anuallIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double firstIncomeCase = AnuallIncome * 14 / 100;
            double secondIncomeCase = AnuallIncome * 16 / 100;

            if (NumberOfEmployees < 10)
            {
                return secondIncomeCase;
            }
            else
            {
                return firstIncomeCase;
            }
        }
    }
}