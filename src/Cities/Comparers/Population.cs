using System.Collections.Generic;



namespace Cities.Comparers
{
    public class PopulationComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            // Since we want to sort integers, we can use the
            // comparer for the built-in integer class after converting teh strings in the file to integers

            return  x.Population.CompareTo(y.Population);
        }
    }
}
