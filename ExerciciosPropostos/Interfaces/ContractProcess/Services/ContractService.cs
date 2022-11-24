using System;
using ContractProcess.Entities;

namespace ContractProcess.Services
{
    public class ContractService
    {
        private iPaymentFee _paymentFee;

        public ContractService(iPaymentFee paymentFee)
        {
            _paymentFee = paymentFee;
        }

        public void ProcessContract(Contract contract)
        {
            double basicValue = contract.TotalValue / contract.Months;

            for (int i = 0; i < contract.Months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateValue = basicValue + _paymentFee.Interest(basicValue, i);
                double fullValue = updateValue + _paymentFee.Fee(updateValue);
                contract.AddInstallment(new Installment(date, fullValue));
            }
        }
    }
}