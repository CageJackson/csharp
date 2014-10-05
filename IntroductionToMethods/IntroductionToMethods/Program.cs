using System;

namespace IntroductionToMethods
{
    class Program
    {
        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        public static void Main(string[] args)
        {
            Person person = new Person("Donnie", 35);
            
            Console.WriteLine(person.GetName());
            Console.WriteLine(person.GetAge());

            person.SetName("Michael");
            person.SetAge(27);

            Console.WriteLine(person.GetName());
            Console.WriteLine(person.GetAge());

            Console.ReadLine();
        }

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////
    }
}