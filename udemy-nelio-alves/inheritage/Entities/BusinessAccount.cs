public class BusinessAcount : Account
{
    public double LoanLimit { get; set; }

    public LoanLimit()
    {
    }
    public LoanLimit(int number, string holder, double balance, double loanLimit)
        : base(number, holder, balance)
    {
        LoanLimit = loanLimit;
    }

    public void Loan(double amount)
    {
        if (LoanLimit is <= Balance)
        {
            Balance -= amount;

        }
    }
}