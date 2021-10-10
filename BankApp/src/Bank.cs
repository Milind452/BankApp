using System;

namespace BankApp
{
    class Bank
    {
        public void Login()
        {

        }

        public void Register()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your username: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string username = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your password: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string password = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Select type of account");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Savings account");
            Console.WriteLine("2. Recurring Deposit account");
            Console.WriteLine("3. Fixed Deposit account");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your choice: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            int ch = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            Console.WriteLine(username);
            Console.WriteLine(password);
            Console.WriteLine(ch == 1 ? "Savings" : ch == 2 ? "Recurring" : "Fixed");
            // CreateUser(username, password, accountType);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Bank bank = new Bank();
            int ch;
            do
            {
                //Console.ReadLine();
                //Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("___CHOICES___");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Close");
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
                        bank.Register();
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("# Invalid entry. Try again.\n");
                        break;
                }
            } while (ch != 3);
        }
    }
}
