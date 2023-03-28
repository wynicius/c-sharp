using System;
using System.Globalization;

ContaBancaria conta;

System.Console.Write("Entre com o número da conta: ");
int numeroConta = int.Parse(Console.ReadLine());

System.Console.Write("Entre com o nome titular da conta: ");
string titular = Console.ReadLine();

char depositCondition = ' ';

do {
    System.Console.Write("Haverá depósito inicial (s/n)? ");
    string input = Console.ReadLine();
    if (string.IsNullOrEmpty(input)) {
        System.Console.WriteLine("Entrada inválida! Digite 's' para sim ou 'n' para não.");
        continue;
    }
    depositCondition = char.ToLower(input[0]);

    if (depositCondition != 's' && depositCondition != 'n') {
        System.Console.WriteLine("Entrada inválida! Digite 's' para sim ou 'n' para não.");
    }
}   while (depositCondition != 's' && depositCondition != 'n');

if (depositCondition == 's') {
    System.Console.Write("Entre com o valor do depósito: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    conta = new ContaBancaria(numeroConta, titular, depositoInicial);
}
else {
    conta = new ContaBancaria(numeroConta, titular);
}

Console.WriteLine();
Console.WriteLine("Dados da conta:");
System.Console.WriteLine(conta);


System.Console.Write("Entre um valor para depósito: ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(quantia);

System.Console.WriteLine("Dados da conta atualizados: ");
System.Console.WriteLine(conta);

System.Console.WriteLine("Entre um valor para saque: ");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(quantia);

System.Console.WriteLine("Dados da conta atualizados: ");
System.Console.WriteLine(conta);

