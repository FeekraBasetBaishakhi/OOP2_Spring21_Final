using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface1
{
    class Calculator1 : IBasicCalculator
    {
        int x = 15;
        int y = 30;
        public int division(int x, int y)
        {
            return x / y;
        }

        public int multiplication(int x, int y)
        {
            return x*y;
        }

        public int sub(int x, int y)
        {
            return x - y;
        }

        public int sum(int x, int y)
        {
            return x + y;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Sum :{0}" ,(x + y));
            Console.WriteLine("Sub :{0}", (x - y));
            Console.WriteLine("Division :{0}", (x / y));
            Console.WriteLine("Multiplication :{0}", (x * y));

        }
    }
}
