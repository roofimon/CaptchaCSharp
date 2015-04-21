using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnit
{
    class Account : NUnit.IAccount
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public void TransferFunds(Account destination, decimal amount)
        {
            destination.Deposit(amount);
            Withdraw(amount);
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public string DoSomething()
        {
            return null;
        }
    }
}
