using System.Collections.Generic;


namespace Cities.Comparers
{
    public class CompoundComparer : IComparer<City>
    {

        public List<IComparer<City>> Comparers = new List<IComparer<City>>();
        public int Compare(City x, City y)
        {
            int result = 0;
            foreach (IComparer<City> comparerType in Comparers)
            {

                result = comparerType.Compare(x, y);
                if (result != 0) { return result; }
                 
            }
            return result;

        }
    }
}