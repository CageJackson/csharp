using System;

namespace Example1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person A = new Person();
            A.Name = "Donnie";
            A.Age = 35;

            Person B = new Person();
            B.Name = "Michael";
            B.Age = 27;

            Console.WriteLine(A.Name + ", " + A.Age);
            Console.WriteLine(B.Name + ", " + B.Age);
            Console.ReadLine();
        }
    }
}