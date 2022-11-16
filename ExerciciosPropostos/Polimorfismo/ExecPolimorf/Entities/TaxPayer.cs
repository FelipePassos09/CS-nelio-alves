using ExecPolimorf.Entities.Enums;

namespace ExecPolimorf.Entities
{
    public abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        public TaxPayerType Type { get; set; }
        
        public TaxPayer() {}

        public TaxPayer(string name, double anualIncome, TaxPayerType type)
        {
            Name = name;
            AnualIncome = anualIncome;
            Type = type;
        }

        public virtual double TotalTaxes()
        {
            return 0;
        }
        
    }
}