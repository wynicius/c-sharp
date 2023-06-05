using System;
using System.Globalization;

Console.WriteLine("Enter contrat data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.Parse(Console.ReadLine());
Console.Write("Contract Value: ");
double totalValue = double.Parse(Console.ReadLine());
Console.Write("Enter number of installments: ");
int months = int.Parse(Console.ReadLine());

Contract contract = new Contract(number, date, totalValue);
ContractService service = new ContractService(new PaypalService());

service.ProcessContract(contract, months);

System.Console.WriteLine("Installments: ");
System.Console.WriteLine(contract);