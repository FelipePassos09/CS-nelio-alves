namespace ExemploInterfaces.Services
{
    public class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            double tax = amount <= 100.00 ?  amount * 0.2 : amount * 0.15;

            return tax;
        }
    }
}