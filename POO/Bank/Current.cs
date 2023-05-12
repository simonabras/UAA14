namespace Bank
{
    public class Current : Account
    {
        // Private attributes
        private int _overdraft;

        // Constructor
        public Current(string number, double balance, int overdraft)
        {
            _number = number;
            _balance = balance;
            _overdraft = overdraft;
        }

        // Properties
        public int Overdraft
        {
            get { return _overdraft; }
            set { _overdraft = value; }
        }

        // Methods
        public override bool Withdraw(double amount)
        {
            if(amount <= _balance + _overdraft)
            {
                _balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Pay(Account account, double amount)
        {
            if(amount <= _balance + _overdraft)
            {
                _balance -= amount;
                account.Balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}