using System;
using System.Collections.Generic;
using ExecPolimorf.Entities.Enums;
using ExecPolimorf.Entities;
using System.Globalization;



namespace ExecPolimorf
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int nPayers = int.Parse(Console.ReadLine());

            List <TaxPayer> payerList = new List<TaxPayer>();

            for (int i = 0; i < nPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data: ");
                Console.Write("Individual or Company? ");
                TaxPayerType payerType = (TaxPayerType) Enum.Parse(typeof(TaxPayerType),Console.ReadLine());
                Console.Write("Name: ");
                string payerName = Console.ReadLine();
                Console.Write("Anual Income: ");
                double payerIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (payerType == TaxPayerType.Individual)
                {
                    Console.Write("Health costs: ");
                    double payerHealth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    payerList.Add(new Individual(payerName, payerIncome, payerType, payerHealth));
                }
                else if (payerType == TaxPayerType.Company)
                {
                    Console.Write("Number employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    
                    payerList.Add(new Company(payerName, payerIncome, payerType, numberEmployees));
                }
            }

            foreach (var payer in payerList)
            {
                Console.WriteLine("TAXES PAID:");
                Console.WriteLine(payer.Name + " : $ " + payer.TotalTaxes());
            }
        }
    }
}