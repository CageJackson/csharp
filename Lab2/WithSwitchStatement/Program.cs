using System;

namespace WithSwitchStatement
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

            string name;

            switch (eyeColor)
            {
                case "blue": name = isMale ? "Joe" : "Sally"; break;
                case "brown": name = isMale ? "Dave" : "Jane"; break;
                case "green": name = isMale ? "John" : "Phoebe"; break;
                default: name = "Unknown"; break;
            }

            Console.WriteLine("Your Name Is " + name + ".");
            Console.ReadKey();
        }
    }
}