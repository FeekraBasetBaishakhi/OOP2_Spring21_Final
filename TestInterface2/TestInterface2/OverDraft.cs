using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface2
{
    class Overdraft : Account, IBasicBanking
    {
        public int limit { get; set; }

        public Overdraft() { }
        public Overdraft(string accName, string accNo, double balance, int limit) : base(accName, accNo, balance)
        {
            this.limit = limit;
        }

        public override void deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine("Your money deposited by {0} to self", amount);

        }

        public override void withdraw(int amount)
        {
            if (amount <= Balance + limit)
            {
                Balance -= amount;
                Console.WriteLine("Your money has been widrawn by {0} to self", amount);

            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }

        }
    }
}