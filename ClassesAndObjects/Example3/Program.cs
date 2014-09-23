using System;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            var record = new Record();
            record.OwnerName = "Donnie";
            record.OwnerID = 123;
            record.IsActive = true;

            Console.WriteLine(record.GetFormattedString());
            Console.ReadLine();
        }
    }
}