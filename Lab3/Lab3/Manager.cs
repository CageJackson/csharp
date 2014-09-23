namespace Lab3Hard_Solution
{
    public class Manager
    {
        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        private double sumOfAllAges;
        private int totalNumberOfPeople;

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        public void UpdatePersonStatics(Person person)
        {
            updateAverageAge(person);
            updateOldestAndYoungest(person);
        }

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        private void updateAverageAge(Person person)
        {
            sumOfAllAges += person.Age;
            totalNumberOfPeople++;

            if (person.IsMarried())
            {
                sumOfAllAges += person.Spouse.Age;
                totalNumberOfPeople++;
            }

            Person.AverageAge = sumOfAllAges / totalNumberOfPeople;
        }

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        private void updateOldestAndYoungest(Person person)
        {
            if (Person.Oldest == null || person.Age > Person.Oldest.Age)
            {
                Person.Oldest = person;
            }

            if (Person.Youngest == null || person.Age < Person.Youngest.Age)
            {
                Person.Youngest = person;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////
    }
}