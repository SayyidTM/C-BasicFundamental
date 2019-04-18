using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaringText
{
    class Program
    {
        static void Main(string[] args)
        {
            var senetce = "ini akang menjadi sesuatu yang sangata panjang";
            string summary = StringUtility.SummerizeText(senetce, 25);
            Console.WriteLine(summary);

        }
    }
}
