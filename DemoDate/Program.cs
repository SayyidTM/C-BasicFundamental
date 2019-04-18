using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDate
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2019, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("jam berapa sekarang: " + now.Hour);
        }
    }
}
