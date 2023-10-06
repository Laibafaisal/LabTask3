using Person;
using System;

namespace Person
{
    public class Female
    {
        public Female()
        {
            Console.WriteLine("i am the constructor of class female");
        }

        public string Name { get; set; }
    }
}

namespace _213002_Snip2
{
    class Program
    {
        static void Main(string[] args)
        {
            Female f = new Female();
            f.Name = "Cindy";
            Console.WriteLine($"Her name is: {f.Name}");
        }

        static void SaySomething()
        {
            Console.WriteLine("I don't even know your name. Don't order me!");
        }

        static void SaySomething(string first)
        {
            Console.WriteLine($"Cheers, {first}\n");
            //Trying string concatenation
            //Console.WriteLine("Cheers "+ first);
        }

        static void SaySomething(string first, string last)
        {
            Console.WriteLine($"Cheers, {first} {last}");
        }
    }
}

