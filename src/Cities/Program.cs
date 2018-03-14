using System;
using System.Collections.Generic;
using Cities.Comparers;

namespace Cities
{
    public class Program
    {
        public static void Main(string[] args)
        {
             List<City> cities = CityDataImporter.LoadData();
            
            // TODO Swap out comparers as desired
            IComparer<City> comparer = new NameComparer();

            cities.Sort(comparer);

            PrintCities(cities);

            Console.ReadLine();


            IComparer<City> comparerState = new StateComparer();
            cities.Sort(comparerState);

            PrintCities(cities);

            Console.ReadLine();

            IComparer<City> comparerArea = new AreaComparer();
            cities.Sort(comparerArea);

            PrintCities(cities);

            Console.ReadLine();
         
            IComparer<City> comparerPopulation = new PopulationComparer();
            cities.Sort(comparerPopulation);

            PrintCities(cities);

            Console.ReadLine();

            CompoundComparer comparerCompound = new CompoundComparer();


            comparerCompound.Comparers.Add(new StateComparer());
            //cities.Sort(comparerCompound);
            comparerCompound.Comparers.Add(new PopulationComparer());
            //cities.Sort(comparerCompound);
            cities.Sort(comparerCompound);
            PrintCities(cities);

            Console.ReadLine();

        }

        private static void PrintCities(List<City> cities)
        {
            Console.WriteLine(City.GetTableHeader());

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }
    }
}
