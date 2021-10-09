using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    abstract class Account
    {
        private string accountNumber
        {
            get => accountNumber;
            set => accountNumber = value;
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
        private double balance
        {
            get => balance;
            set => balance = value;
        }
    }
}
