using System;
using Person;

namespace Person
{
    public class Female
    {
        public string Name { get; set; }
    }
}


namespace _213002_code3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.Female fem = new Female();
            fem.Name = "Cindy";
            Console.WriteLine($"Her name is: {fem.Name}");
        }


}
}
