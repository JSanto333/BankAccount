using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            Console.WriteLine("Welcome to your bank!");
            Client cl = new Client("Ferris", "Bueller", "1234 Chicago, Illinois", "555-0095");
            SavingsAccount sa = new SavingsAccount(1000.75M);
            CheckingAccount ca = new CheckingAccount(1000.25M);
            decimal BalanceValue = 100;
            do
            {
                Console.WriteLine("Please enter your selection!");
                Console.WriteLine("1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");

                answer = (Console.ReadLine());



                if (answer == "1")
                {
                    cl.GetClientInfo();
                    Console.WriteLine("Press any key to continue");
                    answer = (Console.ReadLine());
                }
                if (answer == "2")
                {
                    Console.WriteLine("a. Checking Account\nb. Savings Account");
                    string selection = Console.ReadLine().ToLower();
                    if (selection == "a")
                    {
                        Console.WriteLine("Checking account balance is {0:C}", ca.Balance);

                        answer = (Console.ReadLine());
                    }
                    if (selection == "b")
                    {

                        Console.WriteLine("Savings account balance is {0:C}", sa.Balance);
                        answer = (Console.ReadLine());
                    }
                    else
                    {
                        continue;
                    }

                }
                if (answer == "3")
                {
                    Console.WriteLine("a. Deposit Into Checking Account\nb. Deposit Into Savings Account");
                    string selection = Console.ReadLine().ToLower();
                    if (selection == "a")
                    {
                        Console.WriteLine("How much would you like to deposit?");
                        decimal credit = decimal.Parse(Console.ReadLine());
                        ca.Balance = ca.Deposit(credit);
                        Console.WriteLine("Your new balance is " + ca.Balance);
                    }
                    if (selection == "b")
                    {
                        Console.WriteLine("How much would you like to deposit?");
                        decimal credit = decimal.Parse(Console.ReadLine());
                        sa.Balance = sa.Deposit(credit);
                        Console.WriteLine("Your new balance is " + sa.Balance);
                    }
                    else
                    {
                        continue;
                    }

                }
                if (answer == "4")
                {
                    Console.WriteLine("a. Withdraw From Checking Account\nb. Withdraw From Savings Account");
                    string selection = Console.ReadLine().ToLower();
                    if (selection == "a")
                    {
                        Console.WriteLine("How much would you like to withdraw?");
                        decimal debit = decimal.Parse(Console.ReadLine());
                        if(debit > ca.Balance)
                        {
                            Console.WriteLine("Insufficient Funds, enter a different amount");
                            debit = decimal.Parse(Console.ReadLine());
                        }
                        ca.Balance = ca.Withdraw(debit);
                        Console.WriteLine("Your new balance is " + ca.Balance);
                    }
                    if (selection == "b")
                    {
                        Console.WriteLine("How much would you like to withdraw?");
                        decimal debit = decimal.Parse(Console.ReadLine());
                        if (debit > sa.Balance - BalanceValue)
                        {
                            Console.WriteLine("Insufficient Funds, enter a different amount");
                            debit = decimal.Parse(Console.ReadLine());
                        }
                        sa.Balance = sa.Withdraw(debit);
                        Console.WriteLine("Your new balance is " + sa.Balance);
                    }
                    else
                    {
                        continue;
                    }
                }
            } while (answer != "5");
        }
    }
}
