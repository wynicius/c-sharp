﻿using System.Globalization;


List<Employee> list = new List<Employee>();

Console.WriteLine("------------------");
Console.WriteLine("------Hello!------");
Console.WriteLine("------------------");

Console.Write("Enter the number of employees: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++) 
{
    Console.WriteLine($"Employee #{i+1} data: ");
    Console.Write("Outsourced (y/n)? ");
    char employeeType = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine());
    
    if (employeeType == 'y')
    {
        Console.WriteLine("Additional Charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));

    }
    else
    {
        list.Add(new Employee(name, hours, valuePerHour));
    }
    
    Console.WriteLine();
    System.Console.WriteLine();
    Console.WriteLine("PAYMENTS:");
        foreach (Employee emp in list)
        {
            Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
        }
}


