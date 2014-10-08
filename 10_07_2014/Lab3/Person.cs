namespace Lab3
{
    class Person
    {
        #region Static

        public static Person Youngest;

        public static int SumOfAllAges;
        public static int TotalNumberOfPeople;

        public static double ComputeAverageAge()
        {
            double sumOfAllAges = (double) SumOfAllAges;
            double totalNumberOfPeople = (double) TotalNumberOfPeople;
            return sumOfAllAges / totalNumberOfPeople;
        }

        #endregion

        #region Instance Variables

        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;

        #endregion
    }
}