using System;
using ExercicioHeranca.Entities;

namespace ExercicioHeranca
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Account account = new Account
            (
                number: 12347,
                holder: "Felipe Passos",
                balance: 1400.17
            );

            Console.WriteLine(account.Balance);
            
            account.Deposit(250.76);

            Console.WriteLine(account.ToString());

            BusinessAccount steps = new BusinessAccount(
                number: 123476,
                holder: "Felipe Passos",
                balance: 2000,
                loanLimit: 4000
            );

            Console.WriteLine("Limite Disponível: " + steps.LoanLimit);
            Console.WriteLine("Saldo Atual: " + steps.Balance);
            
            steps.Loan(3500.59);
            
            Console.WriteLine("Limite Disponível: " + steps.LoanLimit);
            Console.WriteLine("Saldo Atual: " + steps.Balance);

            Account poup = new Account(number :12345, holder:"Felipe", balance: 0.00);

            Account poupanca = new SavingsAccount(number :12345, holder:"Felipe", balance: 0.00, interestRate: 10);
            
            poupanca.Deposit(1000);

            Console.WriteLine(poupanca.Balance);
            
            poupanca.Withdraw(100);
            
            Console.WriteLine(poupanca.Balance);
            
            poup.Deposit(1000);
            
            poup.Withdraw(100);

            Console.WriteLine(poup.Balance);

        }
    }
}