using System;

namespace Example2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Point P1 = new Point();
            P1.X = 5.5;
            P1.Y = 10.2;
            P1.Z = 7.9;

            Point copyOfP1 = new Point();
            copyOfP1.X = P1.X;
            copyOfP1.Y = P1.Y;
            copyOfP1.Z = P1.Z;

            Console.WriteLine();
            Console.WriteLine("copyOfP1.X  :  " + copyOfP1.X);
            Console.WriteLine("copyOfP1.Y  :  " + copyOfP1.Y);
            Console.WriteLine("copyOfP1.Z  :  " + copyOfP1.Z);
            Console.WriteLine();
            Console.WriteLine("Is P1 the same object as copyOfP1? ---> " + (P1 == copyOfP1));

            Point P2 = new Point();
            P2.X = 72.3;
            P2.Y = 44.4;
            P2.Z = 68.1;

            Point referenceToP2 = P2;

            Console.WriteLine();
            Console.WriteLine("referenceToP2.X  :  " + referenceToP2.X);
            Console.WriteLine("referenceToP2.Y  :  " + referenceToP2.Y);
            Console.WriteLine("referenceToP2.Z  :  " + referenceToP2.Z);
            Console.WriteLine();
            Console.WriteLine("Is P2 the same object as referenceToP2? ---> " + (P2 == referenceToP2));

            Console.ReadLine();
        }
    }
}