namespace Taxes.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company() { }

        public Company(int numberOfEmployees, string name, double anuallIncome) : base(name, anuallIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double firstIncomeCase = AnuallIncome * 14 / 100;
            double secondIncomeCase = AnuallIncome * 16 / 100;

            if (NumberOfEmployees <= 10)
            {
                return AnuallIncome - secondIncomeCase;
            }
            else
            {
                return AnuallIncome - firstIncomeCase;
            }
        }
    }
}