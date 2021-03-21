using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Feekra", "18390103", 98000);
            Account a3 = new Account("Baset", "19990003", 7000);
            Account a4 = new Account("Baishakhi", "30109381", 54500);

            Transection t1 = new Transection(a1, a3, 22500, "**Sent Money**");
            Transection t2 = new Transection(a3, a4, 1490, "**Receive Money**");
            
            a1.addTransaction(t1);
            a1.ShowInfo();
            a1.showAllTransection();
            Console.WriteLine("**************************");
            a4.addTransaction(t2);
            a4.ShowInfo();
            a4.showAllTransection();



        }
    }
}