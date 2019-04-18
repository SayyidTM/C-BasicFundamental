using DemoClasses.Math;
using System;

namespace DemoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var sayyid = new Persoon();
            sayyid.firstName = "Sayyid";
            sayyid.lastName = "Muhamad";
            sayyid.Introduce();

            Claculator claculator = new Claculator();
            var result = claculator.add(1, 2);
            Console.WriteLine(result);
        }
        
    }
}
