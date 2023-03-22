public class Banco {

    private int _aC;

    private string _name;

    public double Deposit {get; set; }

    public registerWithDeposit (int accountNumber, string name, int deposit) {
        _aC = accountNumber;
        _name = name;
        Deposit = deposit;
    }

    private int _aC {
        get { return _aC; }
        set { 
            if (_aC == 0 && value != 0 ) {
                _aC = value;
            }
        }
    }

    private string _name {
        get { return _name; }
        set { 
            if (value != null && value.Length > 3) {
                _name = value;
            }
        }
    }
}