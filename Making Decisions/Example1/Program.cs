using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            int someNumber = int.Parse(Console.ReadLine());

            if (someNumber >= 0)
            {
                Console.WriteLine("The user entered a positive number");
            }
            else
            {
                Console.WriteLine("The user entered a negative number");
            }

            Console.ReadKey();
        }
    }
}