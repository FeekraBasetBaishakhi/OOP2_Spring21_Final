using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface2
{
    interface IBasicBanking
    {
        bool deposit(int amount);
        bool withdraw(int amount);
    }
}
