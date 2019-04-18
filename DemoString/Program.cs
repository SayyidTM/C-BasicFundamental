using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoString
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "sayid muhamad";
            Console.WriteLine("Trim: {0}", fullName);
            Console.WriteLine("toUpper: {0}", fullName.ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index +1);
            Console.WriteLine("first Name: " + firstName);
            Console.WriteLine("last Name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("sayid", "sayyid"));

            if(String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("invalid");

                var str = "25";
                var age = Convert.ToByte(str);
                Console.WriteLine(age);

                float price = 29.95f;
                Console.WriteLine(price.ToString("C0"));
            }
        }
    }
}
