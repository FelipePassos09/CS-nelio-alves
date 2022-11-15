namespace ExercicioHeranca.Entities
{
    public class BusinessAccount : Account
    {
        public double LoanLimit { get; protected set; }
        
        public BusinessAccount(){}

        public BusinessAccount(int number, double balance, string holder, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            Balance += amount;
            LoanLimit -= amount;
        }
    }
}