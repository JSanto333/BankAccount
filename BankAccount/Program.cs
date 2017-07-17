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
            decimal totalCredit = 0.0M;
            SavingsAccount sa = new SavingsAccount(1000.25M, 0.1M);

            Console.WriteLine("Beginning balance is {0:C}", sa.Balance);
            totalCredit = sa.CalculateInterest();
            Console.WriteLine("Total interest: {0:C}", totalCredit);
            sa.Credit(totalCredit); //adds credit to balance
            Console.WriteLine("Ending balance is: {0:C}", sa.Balance);
            Console.WriteLine();

            //checking account has a fee for every transaction
            CheckingAccount ca = new CheckingAccount(1000.25M, 5.50M);
            Console.WriteLine("Beginning balance is {0:C}", ca.Balance);
            ca.Credit(55.25M); //this adds to the account (-fee)
            ca.Debit(925.55M); //taken from the account (-fee)
            Console.WriteLine("Ending balance is {0:C}", ca.Balance);

            Console.ReadLine();
        }
    }
}
