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
        private decimal _fee;

        //constructor should receive the initial balance, as well as a parameter indicating a fee amount.
        public CheckingAccount(decimal balance, decimal fee) : base(balance)
        {

        }

        public decimal Fee
        {
            get { return _fee; }
            set
            {

            }
        }
    }
}
