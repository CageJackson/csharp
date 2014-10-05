using System;

namespace Lab1_Extras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Name:             ");
            string firstName = Console.ReadLine();
            Console.Write("Middle Initial:         ");
            string middleInitial = Console.ReadLine();
            Console.Write("Last Name:              ");
            string lastName = Console.ReadLine();
            string fullName = firstName + " " + middleInitial + ". " + lastName;

            Console.Write("Age:                    ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Height In Feet: (4/5/6) ");
            int heightFeet = int.Parse(Console.ReadLine());
            Console.Write("Extra Inches:           ");
            double heightInches = double.Parse(Console.ReadLine());
            double totalHeightCM = 2.54 * ((heightFeet * 12) + heightInches);

            Console.Write("Is Citizen: (y/n)       ");
            bool isCitizen = Console.ReadLine().ToLower().StartsWith("y");
            bool canVote = isCitizen && (age >= 18);

            Console.WriteLine();
            Console.WriteLine("Full Name : " + fullName);
            Console.WriteLine("Height CM : " + totalHeightCM);
            Console.WriteLine("Can Vote  : " + canVote);
            Console.ReadLine();
        }
    }
}