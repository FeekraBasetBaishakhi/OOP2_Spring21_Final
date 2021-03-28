using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new SavingsAccount("Feekra", "1839010", 50000.25f);
            Account a2 = new CurrentAccount("Baset", "1839020", 45600.86f);
            Account a3 = new Overdraft("Baishakhi", "1839030", 4070.88f, 6750);
            Console.WriteLine("***DHAKA Bank Limited***");
            a1.ShowInfo();
            a1.deposit(61000);
            Console.WriteLine("\n***DHAKA Bank Limited***");
            a2.ShowInfo();
            a2.withdraw(5000);
            Console.WriteLine("\n***DHAKA Bank Limited***");
            a3.ShowInfo();
            a3.deposit(45450);
            a3.withdraw(4000);

        }
    }
}