using System;
using System.Collections.Generic;

namespace ContractProcess.Entities
{
    public class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public int Months { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue, int months)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Months = months;
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}