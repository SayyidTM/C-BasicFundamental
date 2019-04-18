using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var namber = new int[3];
            namber[0] = 1;

            Console.WriteLine(namber[0]);
            Console.WriteLine(namber[1]);
            Console.WriteLine(namber[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var name = new string[3] { "sayyid", "jody", "gugun" };

            Console.WriteLine(name[0]);
            Console.WriteLine(name[1]);
            Console.WriteLine(name[2]);
        }
    }
}
