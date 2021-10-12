using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class FixedDepositAccount : Account
    {
        public FixedDepositAccount(string accountNumber, string type, double balance) :
            base(accountNumber, type, balance)
        {
            Rate = 0.06;
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
