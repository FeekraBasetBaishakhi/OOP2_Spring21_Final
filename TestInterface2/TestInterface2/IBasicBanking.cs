using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface2
{
    interface IBasicBanking
    {
        void deposit(int amount);
        void withdraw(int amount);
    }
}
