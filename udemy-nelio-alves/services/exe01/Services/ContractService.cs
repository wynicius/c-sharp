using System;
using System.Collections.Generic;
public class ContractService
{
    private IOnlinePaymentService _onlinePaymentService;

    public ContractService(IOnlinePaymentService onlinePaymentService)
    {
        _onlinePaymentService = onlinePaymentService;
    }

    public void ProcessContract(Contract contract, int months)
    {
        PaypalService paypalService = new PaypalService();
        double basicQuota = contract.TotalValue / months;
        
        for (int i = 1; i <= months; i++)
        {
            DateTime dueMonth = (contract.Date).AddMonths(i);
            double sum = _onlinePaymentService.PaymentFee(
                _onlinePaymentService.Interest(paymentPerInstallment, i)
            );
            contract.AddInstallment(dueMonth, sum);
        }
    }
}