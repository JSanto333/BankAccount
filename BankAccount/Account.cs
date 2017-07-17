using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        //one private instance of the variable decimal to represent the account balance
        private decimal _balance;
        
        //constructor that receives an initial balance and uses it to initialize the instance variable public property
        public Account(decimal balance)
        {
            Balance = balance;
        }

        //The property should validate the initial balance
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                    _balance = value;
                else
                    throw new Exception("Balance cannot be negative");
            }
        }

        //Method Credit should add an amount to the current balance
        public virtual void Credit(decimal amount)
        {
            if (amount > 0)
                Balance += amount;
            else
                throw new Exception("Credited amount must be greater than zero");
        }

        //Method Debit should withdraw money from the Account and ensure that the debit amount does not exceed the
        //Account's balance. If it does, the balance should be left unchanged, and the method should display
        //the message "Debit amount exceeded account balance."
        public virtual bool Debit(decimal amount)
        {
            bool OK = true;
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                OK = true;
            }
            else
            {
                Console.Write("Debit amount exceeded account balance.");
                OK = false;
            }

            return OK;
        }
    }
}
