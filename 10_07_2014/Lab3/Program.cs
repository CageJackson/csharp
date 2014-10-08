using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person.TotalNumberOfPeople++;
            Console.Write("What is your first name? ");
            p1.FirstName = Console.ReadLine();
            Console.Write("What is your last name? ");
            p1.LastName = Console.ReadLine();
            Console.Write("What is your age? ");
            p1.Age = int.Parse(Console.ReadLine());
            Person.SumOfAllAges += p1.Age;
            Person.Youngest = p1;

            Console.Write("Are you married? (yes/no) ");

            if (Console.ReadLine() == "yes")
            {
                p1.Spouse = new Person();
                Person.TotalNumberOfPeople++;
                Console.Write("What is your spouse's name? ");
                p1.Spouse.FirstName = Console.ReadLine();
                p1.Spouse.LastName = p1.LastName;
                Console.Write("What is your spouse's age? ");
                p1.Spouse.Age = int.Parse(Console.ReadLine());
                Person.SumOfAllAges += p1.Spouse.Age;

                if (p1.Spouse.Age < p1.Age)
                {
                    Person.Youngest = p1.Spouse;
                }

                p1.Spouse.Spouse = p1;
            }

            Console.WriteLine(Person.ComputeAverageAge());
            Console.WriteLine(Person.Youngest.FirstName);
            Console.ReadLine();
        }
    }
}