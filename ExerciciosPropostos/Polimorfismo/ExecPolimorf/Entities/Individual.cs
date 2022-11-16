using ExecPolimorf.Entities.Enums;

namespace ExecPolimorf.Entities
{
    public class Individual : TaxPayer
    {
        public double HealthCost { get; set; }

        public Individual(string name, double anualIncome, TaxPayerType type, double healthCost)
            : base(name, anualIncome, type)
        {
            HealthCost = healthCost;
        }

        public override double TotalTaxes()
        {
            if (AnualIncome < 20000)
            {
                return AnualIncome + (AnualIncome * (15 / 100)) + (HealthCost * 0.5);
            }
            else
            {
                return AnualIncome + (AnualIncome * (25 / 100)) + (HealthCost * 0.5);
            }
        }
    }
}