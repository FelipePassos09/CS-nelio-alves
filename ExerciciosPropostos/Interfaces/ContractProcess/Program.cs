using System;
using System.Globalization;
using ContractProcess.Entities;
using ContractProcess.Services;

namespace ContractProcess
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("ENTER CONTRACT DATA:");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (DD/MM/YYYY): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter the number of installments: ");
            int nInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(contractNumber, contractDate, contractValue, nInstallments);
            ContractService process = new ContractService(new PaypallService());
            
            process.ProcessContract(contract);
            
            Console.WriteLine("INSTALLMENTS");
            foreach (var installment in contract.Installments)
            {
                Console.WriteLine(installment.ToString());
            }
        }
    }
}