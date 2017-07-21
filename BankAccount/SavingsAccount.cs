using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    //Derived class SavingsAccount should inherit the
    //funcionality of an Account, but also include a decimal instance variable indicating the interest rate
    //(percentage) assigned to the Account.
    class SavingsAccount : Account
    {
        

        public SavingsAccount()
        {
            //default constructor 
        }
        //SavingsAccount's constructor should receive the initial balance,
        //as well as an initial value for the interest rate.
        public SavingsAccount(decimal balance)
        {
            this.balance = balance;
        }
        public decimal Deposit()
        {
            //if (credit > 0)
            //    balance += credit;
            return balance;
        }
        public decimal GetBalance(decimal balance)
        {
            return Balance;
        }
        public override decimal Deposit(decimal credit)
        {
            balance = credit + balance;
            return balance;
        }
        public override decimal Withdraw(decimal debit)
        {
            balance -= debit;
            return balance;

        }
    }
}
