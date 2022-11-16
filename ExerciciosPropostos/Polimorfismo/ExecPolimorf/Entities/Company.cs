using ExecPolimorf.Entities.Enums;

namespace ExecPolimorf.Entities
{
    public class Company : TaxPayer
    {
        public int NumberEmployees { get; set; }

        public Company(string name, double anualIncome, TaxPayerType type, int numberEmployees)
            : base(name, anualIncome, type)
        {
            NumberEmployees = numberEmployees;
        }

        public override double TotalTaxes()
        {
            if (NumberEmployees > 10)
            {
                return AnualIncome += AnualIncome * (14 / 100);
            }
            else
            {
                return AnualIncome += AnualIncome * (16 / 100); }
            
        }
    }
}