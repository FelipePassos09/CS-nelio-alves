namespace ContractProcess.Services
{
    public class PaypallService : iPaymentFee
    {

        private const double FeePercentage = 0.02;
        private const double MonthlyPercentage = 0.01;
        
        public double Interest(double amount, int index)
        {
            return amount * MonthlyPercentage * index;
        }

        public double Fee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}