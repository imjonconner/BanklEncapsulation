using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanklEncapsulation
{
    internal class BankAccount
    {
        private double _balance = 0;

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdrawl(double amount)
        {
            _balance -= amount;
        }

        public void GetBalance()
        {
            Console.WriteLine(_balance);
        }
           
    }
}
