﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Classes
{
     abstract class Account
    {
        // Protected attributes
        protected string _number;
        protected double _balance;

        // Properties
        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        // Methods
        public bool Deposit(double amount)
        {
            _balance += amount;
            return true;
        }
        public abstract bool Withdraw(double amount);
    }
}
