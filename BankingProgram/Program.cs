using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double balance = 0;
            bool isRunning = true;
            int choice;

            // show menu
            while (isRunning)
            {
                Console.WriteLine("");
                Console.WriteLine("*******************************");
                Console.WriteLine("******  BANKING PROGRAM  ******");
                Console.WriteLine("*******************************");
                Console.WriteLine("1. Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdrawal");
                Console.WriteLine("4. Quit");
                Console.WriteLine("*******************************");

                // grap user input
                Console.Write("Enter your choice (1-4):   ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                // For testing
                //Console.Write("You chose option: " + choice);

                if (choice == 1)
                {
                    //Console.WriteLine("Choice is 1");
                    showBalance(balance);
                }
                else if (choice == 2)
                {
                    //Console.WriteLine("Choice is 2");
                    balance = balance + deposit();
                }
                else if (choice == 3)
                {
                    //Console.WriteLine("Choice is 3");
                    balance = balance - withdraw(balance);
                }
                else
                {
                    Console.WriteLine("Good bye!\n");
                    isRunning = false;
                }
            }

        }
        static void showBalance(double balance)
        {
        Console.WriteLine("*******************************");
        Console.WriteLine($"Your balance: ${balance:F2}");
        Console.WriteLine("*******************************");
        }
        static double deposit()
        {
            double amount;
            Console.Write("Enter amount to deposit: ");
            amount = Convert.ToInt32(Console.ReadLine());
        
            if (amount < 0) {
                Console.WriteLine("*******************************");
                Console.WriteLine("No negative numbers.");
                Console.WriteLine("*******************************");
                return 0;
            }
            else {
                return amount;
            }
        }
        static double withdraw(double balance)
        {
            double amount;
            Console.Write("Enter amount to withdraw: ");
            amount = Convert.ToInt32(Console.ReadLine());

            if( amount < 0 ){
                Console.WriteLine("*******************************");
                Console.WriteLine("No negative numbers.");
                Console.WriteLine("*******************************");
                return 0;
            }
            else if( amount > balance ){
                Console.WriteLine("*******************************");
                Console.WriteLine("Insufficient funds.");
                Console.WriteLine("*******************************");
                return 0;
            }
            else {
                return amount;
            }

        }
    }
}