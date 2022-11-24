namespace ContractProcess.Services
{
    public interface iPaymentFee
    {
        double Fee(double amount);
        double Interest(double amount, int index);
    }
}