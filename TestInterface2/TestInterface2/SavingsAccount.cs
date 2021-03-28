using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface2
{
    class SavingsAccount : Account, IBasicBanking
    {

        public SavingsAccount(string AccName, string AccNo, double balance) : base(AccName, AccNo, balance) { }

        override public void deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine("Your money deposited by {0} to self", amount);
        }

        override public void withdraw(int amount)
        {
            if (amount <= Balance * 0.80)
            {
                Balance -= amount;
                Console.WriteLine("Your account debited by {0} to self", amount);

            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
    }
}