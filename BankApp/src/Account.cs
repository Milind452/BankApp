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

        private string _type;
        public string Type
        {
            get => _type;
            set => _type = value;
        }
        private double _rate;
        public abstract double Rate
        {
            get;
            set;
        }
        private double _balance;
        public double Balance
        {
            get => _balance;
            set => _balance = value;
        }
    }
}
