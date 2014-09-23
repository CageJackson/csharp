namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 20;

            Point p2 = new Point();
            p2.X = 30;
            p2.Y = 30;

            Point.Origin = new Point();
            Point.Origin.X = 0;
            Point.Origin.Y = 0;
        }
    }
}