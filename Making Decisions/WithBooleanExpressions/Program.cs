using System;

namespace WithBooleanExpressions
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

            if (isMale && eyeColor == "blue") { name = "Joe"; }
            else if (isMale && eyeColor == "brown") { name = "Dave"; }
            else if (isMale && eyeColor == "green") { name = "John"; }
            else if (!isMale && eyeColor == "blue") { name = "Sally"; }
            else if (!isMale && eyeColor == "brown") { name = "Jane"; }
            else if (!isMale && eyeColor == "green") { name = "Phoebe"; }

            Console.WriteLine("Your Name Is " + name + ".");
            Console.ReadKey();
        }
    }
}