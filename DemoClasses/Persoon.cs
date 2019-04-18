using System;

namespace DemoClasses
{
    public class Persoon
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("nama saya {0} {1} ", firstName, lastName);
        } 
    }
}
