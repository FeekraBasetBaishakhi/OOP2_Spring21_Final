using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass

{
    class OverDraft : Account
    {
        int Limit = 5000;
        public OverDraft(string name, string accNo, double balance) : base(name, accNo, balance)
        {
        }
        override public void Withdraw(double amount)
        {
            if (Limit >= amount)
            {
                Balance = amount ;
                
            }
            else
            {
                Console.WriteLine("You cannot overdraft over 5000 In A Month");

            }

        }
    }
}