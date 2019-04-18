using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPath
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "@c:\User\SayyidMAlkhindi\CBasicFundamental";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

        }
    }
}
