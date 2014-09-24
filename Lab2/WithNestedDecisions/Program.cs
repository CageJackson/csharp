using System;

namespace WithNestedDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gender (M/F) : ");
            string gender = Console.ReadLine().ToLower();
            Console.Write("Eye Color    : ");
            string eyeColor = Console.ReadLine().ToLower();
            bool isMale = gender.ToUpper() == "m";

            string name = "Unknown";

            if (isMale)
            {
                if (eyeColor == "blue") { name = "Joe"; }
                else if (eyeColor == "brown") { name = "Dave"; }
                else if (eyeColor == "green") { name = "John"; }
            }
            else
            {
                if (eyeColor == "blue") { name = "Sally"; }
                else if (eyeColor == "brown") { name = "Jane"; }
                else if (eyeColor == "green") { name = "Phoebe"; }
            }

            Console.WriteLine("Your Name Is " + name + ".");
            Console.ReadKey();
        }
    }
}