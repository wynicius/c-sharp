using System;
try
{
    Account account = new Account(); 

    Console.WriteLine("Enter account data:");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double initialBalance = double.Parse(Console.ReadLine());
    Console.Write("Withdraw limit: ");
    double withDrawLimit = double.Parse(Console.ReadLine());

    Account acc1 = new Account(number, holder, initialBalance, withDrawLimit);
    Console.WriteLine();
    
    Console.Write("Enter amount for withdraw: "); 
    double withdrawAmount = double.Parse(Console.ReadLine());
    acc1.WithDraw(withdrawAmount);

    Console.WriteLine("New balance: " + acc1.Balance);
}
catch (FormatException e)
{
    Console.WriteLine("Error: " + e.Message);
}
catch (DomainException e)
{
    Console.WriteLine("Error: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}



