using System;

namespace MakingDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your Eye Color?    : ");
            string eyeColor = Console.ReadLine().ToLower();

            Console.Write("What is your Gender? (M/F) : ");
            bool isMale = Console.ReadLine().ToUpper().StartsWith("M");

            string name;

            switch (eyeColor)
            {
                case "blue": name = isMale ? "Joe" : "Sally";  break;
                case "brown": name = isMale ? "Dave" : "Jane"; break;
                case "green": name = isMale ? "John" : "Phoebe"; break;
                default: name = "Not Found"; break;
            }


            Console.WriteLine("Your Name Is " + name + ".");
            Console.ReadLine();
        }
    }
}