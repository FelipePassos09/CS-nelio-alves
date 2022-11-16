using System;
using Exceptions.Entities.Exceptions;

namespace Exceptions.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public Double Balance { get; set; }
        public Double WithdrawLimit { get; set; }
        
        public Account(){}

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        
        public void Withdraw(Double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainExceptions("The amount exceeds withdraw limit.");
            }

            if (amount > Balance)
            {
                throw new DomainExceptions("not enough balance.");
            }
            
            Balance -= amount;
        }

    }
}