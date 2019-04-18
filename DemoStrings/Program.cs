using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            var firstName = "sayyid";
            var lastNmae = "alkhindi";

            var fullName = firstName + " " + lastNmae;

            var name = new string[3] { "sayyid", "jody", "gugun" };
            var formatnama = string.Join(",", name);

            var text = @"halo sayyid
Look into the following paths
c:\folder/folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
