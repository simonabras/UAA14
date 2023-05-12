using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Classes
{
    class Savings : Account
    {
        // Private attributes
        private int _interestRate;

        // Constructor
        public Savings(string number, double balance, int interestRate)
        {
            _number = number;
            _balance = balance;
            _interestRate = interestRate;
        }

        // Properties
        public int InterestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; }
        }

        // Methods
        public override bool Withdraw(double amount)
        {
            if (amount <= _balance / 2)
            {
                _balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
