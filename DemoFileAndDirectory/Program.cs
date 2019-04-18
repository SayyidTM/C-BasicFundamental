using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFileAndDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "@c:\somefile.jpg";

            File.Copy("@c:\Picture\myfile.jpg","f:\temp\myfile.jpg", true);
            File.Delete(path);
            if(File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileinfo = new FileInfo(path);
            fileinfo.CopyTo("...");
            fileinfo.Delete();
            if (fileinfo.Exists)
            {
                //
            }
        }
    }
}
