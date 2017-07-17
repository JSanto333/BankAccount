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
            Fee = fee;
        }

        public decimal Fee
        {
            get { return _fee; }
            set
            {
                if (value > 0)
                    _fee = value;
                else
                    throw new Exception("Fee cannot be less than zero");
            }
        }

        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            Balance -= Fee;
        }

        public override bool Debit(decimal amount)
        {
            if (base.Debit(amount))
            {
                Balance -= Fee;
                return true;
            }

            return false;
        }
    }
}
