using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Transaction : ITransaction
    {
        public double Deposit()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("###Deposit###");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter deposit amount: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            double DepositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            return DepositAmount;
        }

        public double Withdrawal()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("###Withdrawal###");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter withdrawal amount: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            double WithdrawalAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            return WithdrawalAmount;
        }

        public double checkBalance()
        {
            return 0.0;
        }
    }
}
