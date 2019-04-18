using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("masukan nama: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;

            }
        }
    }
}
