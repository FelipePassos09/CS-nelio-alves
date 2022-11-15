using System.Dynamic;

namespace ExercicioHeranca.Entities
{
    public class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }
        
        public Account(){}

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual  void Withdraw(double amount)
        {
            Balance -= (amount + 5.5);
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {
            return $"Account Number: {Number}\nHolder Name: {Holder}\nAccount Balance: {Balance}";
        }
    }
}