using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            char middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            firstName = "Donald";
            middleInitial = 'J';
            lastName = "Santos";

            fullName = firstName + " " + middleInitial + ". " + lastName;

            age = 35;
            heightFeet = 6;
            heightInches = 1.25;
            totalHeightCM = 2.54 * ((heightFeet * 12) + heightInches);

            isCitizen = true;
            canVote = isCitizen && (age >= 18);

            Console.WriteLine(fullName);
            Console.ReadLine();
        }
    }
}