using System;
using System.Collections.Generic;
using System.Globalization;
using Exceptions.Entities;
using Exceptions.Entities.Exceptions;

namespace Exceptions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Account> accountList = new List<Account>();
            
            Console.Write("How many accounts to opening: ");
            int qAccounts = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < qAccounts; i++)
            {
                Console.WriteLine("Entre with account data:");
                Console.Write("Number: ");
                int accountNumber = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string accountHolder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double accountBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double accountLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                accountList.Add(new Account(accountNumber, accountHolder, accountBalance, accountLimit));
            }

            foreach (var account in accountList)
            {
                Console.WriteLine($"ACCOUNT #{account.Number}");
                Console.Write("Enter amount to withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                try
                {
                    account.Withdraw(amount);
                    Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
                }
                catch (DomainExceptions e)
                {
                    Console.WriteLine("Withdraw error: " + e.Message);
                }
            }
        }
    }
}