using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    interface ITransaction
    {
        public double Deposit();
        public double Withdrawal();
        public double checkBalance();
    }
}
