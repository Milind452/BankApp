using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    interface ITransaction
    {
        public void Deposit(double amount);
        public void Withdrawal(double amount);
        public double checkBalance();
    }
}
