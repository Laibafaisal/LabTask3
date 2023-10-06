using System;

namespace _213002_code5
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInput();
        }

        private static void GetInput()
        {
            Console.Write("Type your first name and press enter: ");
            string FirstName = Console.ReadLine();
            Console.Write("Type the page number you are on and press enter: ");
            string pg = Console.ReadLine();
            Console.WriteLine($"Hello {FirstName}, your page number is {pg}.");
        }
    }
}
