using System;
using System.Collections.Generic;

public class Installment
{
    public DateTime DueDate { get; set; }
    public double Amount { get; set; }

    public Installment(DateTime dueDate, double amount)
    {
        DueDate = dueDate;
        Amount = amount;
    }
}
