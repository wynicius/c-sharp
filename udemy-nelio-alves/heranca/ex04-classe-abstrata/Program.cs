﻿using System;
using System.Collections.Generic;
using System.Globalization;

List<TaxPayer> taxPayerList = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Tax payer #{i+1} data:");
    Console.Write("Individual or company (i/c)? ");
    char typeOfPayer = Console.ReadLine()[0];
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double income = double.Parse(Console.ReadLine());
    if (typeOfPayer == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine());
        taxPayerList.Add(new Individual(name, income, healthExpenditures));
    }
    else if (typeOfPayer == 'c')
    {
        Console.Write("Number of employees: ");
        int numEmp = int.Parse(Console.ReadLine());
        taxPayerList.Add(new Company(name, income, numEmp));
    }
    else
    {
        Console.WriteLine("Invalid input. Please, try again.");
        i--;
    }
    
}

double sum = 0.0;
Console.WriteLine();
Console.WriteLine("TAXES PAID:");
foreach (TaxPayer payer in taxPayerList)
{
    Console.WriteLine($"{payer.Name}: $ {payer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
    sum += payer.Tax();
}

Console.WriteLine();
Console.Write($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");