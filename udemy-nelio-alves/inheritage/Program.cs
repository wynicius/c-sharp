

Account acc = new Account(1001, "Alex", 0.0);
B bacc = new bu(1002, "Maria", 0.0, 500.0);

// UPCASTING

// de Subclasse para Superclasse

Account acc1 = bacc;
Account acc2 = new BusinessAcount(1003, "Bob", 0.0, 200.0);
Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

// DOWNCASTING

BusinessAcount acc4 = (BusinessAccount)acc2;
acc4.Loan(100.0);

// businessAccount acc5 = (BusinessAccount)acc3; -- Está errada e o compilador ia da erro, com o programa paradando. 

if (acc3 is BusinessAcount)
{
    BusinessAcount acc5 = (BusinessAcount)acc3;
    acc5.Loan(200.0);
    System.Console.WriteLine("Loan!");
}
if (acc3 is SavingsAccount)
{
    SavingsAccount acc5 = acc3 as SavingsAccount; // Palavra as -- Sintaxe alternativa ao casting!
    acc5.UpdateBalance(200.0);
    System.Console.WriteLine("Update!");
}


