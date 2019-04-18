using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            //int i = 1;
            //byte b = i;
            try
            {
                var number = "1234 ";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch(Exception)
            {
                Console.WriteLine("number tidak dapat di conversi ke byte")
            }
        }
    }
}
