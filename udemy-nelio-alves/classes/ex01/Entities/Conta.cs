
public class Account
{
    private double Conta { get; set; }
    private double Saldo { get; set; }
    public Cliente Titular { get; set; }

    public Account(double conta, double saldo, Cliente titular)
    {
        Conta = conta;
        Saldo = saldo;
        Titular = titular;
    }

    public void Deposito(double valor) 
    {
        this.saldo += valor;
    }
    public void Saque(double valor) 
    {
        this.saldo -= valor;
    }

    public double VerSaldo(double valor)
    {
        return saldo;
    }

    
}