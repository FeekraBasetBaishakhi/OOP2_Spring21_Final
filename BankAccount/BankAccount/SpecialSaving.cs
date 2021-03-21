using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    class SpecialSaving : Account
    {
        public SpecialSaving() { }
        public SpecialSaving(string accName, string accNo, double balance) : base(accName, accNo, balance)
        {
        }
        public override void Withdraw(double amount)
        {
            if (Balance - amount >= Balance * 0.2)
            {
                Balance -= amount;
            }
            else
                Console.WriteLine("Withdraw Balance Must Be Min 20% Of OpeningBalance");
        }
        public override void Transfer(Account a, double amount)
        {
            if (Balance - amount >= 5000)
            {
                Balance -= amount;
                a.Balance += amount;
                Console.WriteLine("You account is debited by {0} to acc: {1} ({2})", amount, a.AccName, a.AccNo);
            }
            else
            {
                Console.WriteLine("insufficient balance");
            }
        }

    }
}