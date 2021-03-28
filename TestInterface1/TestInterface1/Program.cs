using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator1 c1 = new Calculator1();
            Calculator2 c2 = new Calculator2();
            Console.WriteLine("****Calculator 1****");
            c1.ShowInfo();
            Console.WriteLine("\n****Calculator 2*****");
            c2.ShowInfo();
        }
    }
}
