using System;

namespace _213002_Snip1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteStatement();
        }

        private static void WriteStatement()
        {
            var FirstName = "James";
            var LastName = "Bond";
            var FullName = FirstName + " " + LastName;
            Console.WriteLine("My name is: " + FullName);

        }
    }
}
