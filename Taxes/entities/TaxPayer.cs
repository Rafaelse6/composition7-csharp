namespace Taxes.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnuallIncome { get; set; }

        public TaxPayer() { }

        public TaxPayer(string name, double anuallIncome)
        {
            Name = name;
            AnuallIncome = anuallIncome;
        }

        public abstract double Tax();

    }
}