using System;

namespace BasicInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringInput;
            int integerInput;
            bool booleanInput;

            Console.Write("Enter A String        : ");
            stringInput = Console.ReadLine();

            Console.Write("Enter An Integer      : ");
            integerInput = int.Parse(Console.ReadLine());

            Console.Write("Enter A Boolean (Y/N) : ");
            booleanInput = Console.ReadLine().ToUpper().StartsWith("Y");

            Console.WriteLine();
            Console.WriteLine(stringInput);
            Console.WriteLine(integerInput);
            Console.WriteLine(booleanInput);

            Console.WriteLine();
            Console.WriteLine("Hit Enter To End Program...");
            Console.ReadLine();
        }
    }
}