using System;
using System.Collections.Generic;
using System.Globalization;

public class Contract
{
    public int Number { get; set; }
    public DateTime Date { get; set; }
    public double TotalValue { get; set; }
    public List<Installment> Installments = new List<Installment>();

    public Contract (int number, DateTime date, double totalValue)
    {
        Number = number;
        Date = date;
        TotalValue = totalValue;
        
    }

    public void AddInstallment(DateTime dueDate, double amount)
    {
        Installments.Add(new Installment(dueDate, amount));
    }

    public override string ToString()
    {
        string result = "";

        foreach (Installment installment in Installments)
        {
            result += installment.DueDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
            + " - "
            + installment.Amount.ToString("F2", CultureInfo.InvariantCulture)
            + "\n";
        }

        return result;
    }
}