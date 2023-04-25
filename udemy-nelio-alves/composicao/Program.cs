using System;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;


Console.Write("Enter department's name: ");
string deptName = Console.ReadLine();

Console.WriteLine("Enter worker data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("How many contracts to this worker? ");
int n = int.Parse(Console.ReadLine());

Department dept = new Department(deptName);
Worker worker = new Worker(name, level, baseSalary, dept);

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter the #{i} contract data:");
    Console.Write ("Date (DD/MM/YYYY):");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine());
    Console.Write("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());

    HourContract contract = new HourContract(date, valuePerHour, hours);
    worker.AddContract(contract);
}

System.Console.WriteLine();
System.Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string monthAndYear = Console.ReadLine();

int month = int.Parse(monthAndYear.Substring(0 , 2));
int year = int.Parse(monthAndYear.Substring(3));

System.Console.WriteLine("Name: " + worker.Name);
System.Console.WriteLine("Department: " + worker.Department.Name);
System.Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year,  month).ToString("F2", CultureInfo.InvariantCulture)}");