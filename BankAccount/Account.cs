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
        protected decimal balance;
        protected decimal debit;
        protected decimal credit;


        //The property should validate the initial balance
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }

        }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }

        public Account()
        {
            //default constructor
        }
        //constructor that receives an initial balance and uses it to initialize the instance variable public property
        public Account(decimal balance)
        {
            this.balance = Balance;
            this.debit = Debit;
            this.credit = Credit;
        }

        //Method Credit should add an amount to the current balance
        public virtual decimal GetBalance()
        {
            return balance;
        }
        
        public virtual decimal Deposit(decimal credit)
        {            
                //balance = credit + balance;
            return balance;
        }

        public virtual decimal Withdraw(decimal debit)
        {
            return balance;
        }
        //Method Debit should withdraw money from the Account and ensure that the debit amount does not exceed the
        //Account's balance. If it does, the balance should be left unchanged, and the method should display
        //the message "Debit amount exceeded account balance."
        //public virtual bool Debit()
        //{
        //    bool OK = true;
        //    if (Balance - amount >= 0)
        //    {
        //        Balance -= amount;
        //        OK = true;
        //        return OK;
        //    }



    }
}

