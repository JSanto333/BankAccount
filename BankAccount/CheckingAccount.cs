using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    //CheckingAccount should inherit from base class Account and include a decimal instance
    //variable that represents the fee charged per transaction.
    class CheckingAccount : Account
    {
        //protected decimal withdrawAmount;
        //protected decimal depositAmount;

        //public decimal WithdrawAmount { get; set; }
        //public decimal DepositAmount { get; set; }
        
        
        public CheckingAccount()
        {
           //default constructor 
        }
        public CheckingAccount(decimal balance)
        {
            this.balance = balance;
        }
        public decimal GetBalance(decimal balance)
        {
            return balance;
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
