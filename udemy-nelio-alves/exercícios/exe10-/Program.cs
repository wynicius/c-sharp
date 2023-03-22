System.Console.Write("Entre com o número da conta: ");
int accountNumber = Console.ReadLine();

System.Console.Write("Entre com o nome titular da conta: ");
string name = Console.ReadLine();

System.Console.Write("Haverá depósito inicial (s/n)? ");

if (depositCondition == s) {
    System.Console.Write("Entre com o valor do depósito: ");
    int depositCondition = Console.ReadLine();
    
    Banco registerWithDeposit = new Banco(accountNumber, name, depositCondition);
} 
else {
    Banco registerNoDeposit = new Banco(accountNumber, name);
}







