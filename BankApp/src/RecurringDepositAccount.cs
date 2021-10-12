using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class RecurringDepositAccount : Account
    {
        public RecurringDepositAccount(string accountNumber, string type, double balance) : 
            base(accountNumber, type, balance)
        {
            Rate = 0.05;
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
