using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasicFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            char character = 'A';
            string firstName = "sayyid";
            bool isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0}, {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0}, {1}", float.MinValue, float.MaxValue);

            Console.ReadKey();
        }
        
    }
}
