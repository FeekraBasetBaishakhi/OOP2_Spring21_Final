using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    class Program
    {
        
            static void Main(string[] args)
            {   
                Account a1 = new SpecialSaving("Feekra ", "39010", 50000);
                OverDraft o1 = new OverDraft("Feekra ", "39010", 50000);
                Account a2 = new SpecialSaving("Baishakhi", "183", 5000);
                OverDraft o2 = new OverDraft("Baishakhi", "183", 5000);

               
            Console.WriteLine("**********************************");
                a1.Withdraw(10000);
                o1.Withdraw(55000);
                a1.ShowInfo();
                o1.ShowInfo();
                
            Console.WriteLine("**********************************");
                a2.Withdraw(4500);
                o2.Withdraw(4600);
                a2.ShowInfo();
                o2.ShowInfo();

        }
     }
 
}
