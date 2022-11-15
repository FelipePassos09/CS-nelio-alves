namespace ExercicioHeranca.Entities
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; protected set; }
        
        public SavingsAccount(){}

        public SavingsAccount(double interestRate, double balance, string holder, int number) 
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void updateBalance()
        {
            Balance += (Balance * InterestRate)/100 ;
        }
    }
}