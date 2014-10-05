using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 1000);

            ///////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////

            if (randomNumber > 500)
            {
                Console.WriteLine("High");
            }

            ///////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////

            if (randomNumber > 500)
            {
                Console.WriteLine("High");
            }
            else
            {
                Console.WriteLine("Low");
            }

            ///////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////

            if (randomNumber > 666)
            {
                Console.WriteLine("High");
            }
            else if (randomNumber > 333)
            {
                Console.WriteLine("Medium");
            }
            else
            {
                Console.WriteLine("Low");
            }

            ///////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////

            Console.ReadLine();
        }
    }
}