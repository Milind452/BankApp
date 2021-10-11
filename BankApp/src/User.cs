using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class User
    {
        private string _username;
        public string Username
        {
            get => _username;
            set => _username = value;
        }
        private string _password;
        public string Password
        {
            get => _password;
            set => _password = value;
        }
        private int _accountType;
        public int AccountType
        {
            get => _accountType;
            set => _accountType = value;
        }
        public User(string username, string password, int accountType)
        {
            this._username = username;
            this._password = password;
            this._accountType = accountType;
        }
        public void Dashboard()
        {
            int ch;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("User Dashboard");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. View balance");
                Console.WriteLine("4. View account details");
                Console.WriteLine("5. Close");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter your choice: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                ch = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                switch (ch)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
            } while (ch != 5);
        }
    }
}
