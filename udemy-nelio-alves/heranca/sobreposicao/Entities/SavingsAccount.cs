public class SavingsAccount : Account
{
    public double InterestRate { get; set; }

    public SavingsAccount()
    {

    }
    public SavingsAccount(int number, string holder, double balance, double interestRate) 
        : base(number, holder, balance)
    {
        InterestRate = interestRate;
    }

    public void UpdateBalance()
    {
        Balance += Balance * InterestRate;
    }

    public void Deposit(double amount) 
    {
        Balance += amount;
    }
    public override void Withdraw(double amount) // Withdraw -- Ignorando o virtual dado n SuperClasse
    {
        Balance -= amount;
    }
    
}