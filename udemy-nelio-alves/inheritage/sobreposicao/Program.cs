Account acc1 = new Account(1001, "Alex", 500.0);
Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

acc1.Withdraw(10.0);
acc2.Withdraw(10.0);

Console.WriteLine(acc1.Balance);// output: 485
// A operação abaixo está com override, realizando a operação normal (com base.), e decontando mais uma taxa de 12.0
Console.WriteLine(acc2.Balance);// output: 473