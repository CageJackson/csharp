using System;

namespace Lab3Hard_Solution
{
    class Program
    {
        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.UpdatePersonStatics(createPerson("Person #1"));
            manager.UpdatePersonStatics(createPerson("Person #2"));
            manager.UpdatePersonStatics(createPerson("Person #3"));
            Person.PrintStaticValues();
        }

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        private static Person createPerson(string promptPrefix)
        {
            Question.SetPromptPrefix(promptPrefix);

            Person person = new Person();
            person.FirstName = Question.AskForString("First Name");
            person.LastName = Question.AskForString("Last Name");
            person.Age = Question.AskForInteger("Age");

            if (Question.AskForBoolean("Married?"))
            {
                person.Spouse = new Person();
                person.Spouse.FirstName = Question.AskForString("Spouse Name");
                person.Spouse.Age = Question.AskForInteger("Spouse Age");
                person.Spouse.LastName = person.LastName;
                person.Spouse.Spouse = person;
            }

            Console.WriteLine();

            return person;
        }

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////
    }
}