using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    abstract class Account
    {
        private string _accountNumber;
        public string AccountNumber
        {
            get => _accountNumber;
            set => _accountNumber = value;
        }
        
        protected abstract string type
        {
            get;
            set;
        }
        protected abstract double rate
        {
            get;
        }
        private double _balance;
        public double Balance
        {
            get => _balance;
            set => _balance = value;
        }
    }
}
