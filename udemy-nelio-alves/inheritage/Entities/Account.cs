public class Account 
{
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balance { get; protected set; } // Protected --

    public Account()
    {
    }
    public Account(int number, string holder, double balance)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
    }
    
    public virtual void Withdraw(double amount)
    {
        return Balance -= amount + 5.0;
    }
    public void Deposit(double amount)
    {
        return Balance += amount;
    }

}
