using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            //Console.WriteLine((float)a / (float)b);
            //Console.WriteLine((a + b) *c);
            //Console.WriteLine(c > b && c > a);
            Console.WriteLine(!(c > b || c == a));
            

            Console.ReadKey();
        }
    }
}
