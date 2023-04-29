using System.Collections.Generic;
using System.Globalization;

// Account list = new Account();  --||  Would not Work bc it's a abstract class.
List<Account> list = new List<Account>();

list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
list.Add(new BusinessAccount(1002,"Maria", 500.0, 0.01));
list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

double sum = 0.0;
foreach (Account acc in list) // Usando a classe abstrata
{
    sum += acc.Balance;    
}

Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

