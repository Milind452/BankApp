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
                Console.Write("Enter your choice: ", Console.ForegroundColor);
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
