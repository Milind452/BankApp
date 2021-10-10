using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class RecurringDepositAccount : Account
    {
        public RecurringDepositAccount()
        {
            Rate = 0.05;
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
