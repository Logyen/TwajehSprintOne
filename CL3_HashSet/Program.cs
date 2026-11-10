using System;
using System.Collections.Generic;

namespace HashSetPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating
            HashSet<string> countries = new HashSet<string>();
            var employees = new HashSet<string>() { "Ahmed", "Logyen", "Mohamed" };
            HashSet<int> numbers = new HashSet<int>();

            //Add elements
            countries.Add("Egypt");
            countries.Add("Morocco");
            countries.Add("Argentina");
            countries.Add("Spain");
            countries.Add("USA");

            //HashSet does not allow duplicate elements
            countries.Add("Egypt");
            countries.Add("USA");

            Console.WriteLine("------Countries------");
            display(countries);

            //Check if element exists
            Console.WriteLine("------Contains------");
            Console.WriteLine($"Contains Egypt: {countries.Contains("Egypt")}");
            Console.WriteLine($"Contains France: {countries.Contains("France")}");

            //Count elements
            Console.WriteLine($"Count: {countries.Count}");

            //Remove element
            Console.WriteLine("------Remove------");
            countries.Remove("Spain");
            display(countries);

            //Remove all elements
            Console.WriteLine("------RemoveWhere------");
            countries.RemoveWhere(country => country.StartsWith("A"));
            display(countries);

            //Add elements again
            countries.Add("Canada");
            countries.Add("Germany");
            countries.Add("Japan");

            //UnionWith
            Console.WriteLine("------UnionWith------");
            HashSet<string> newCountries = new HashSet<string>() { "France", "Italy", "Japan" };
            countries.UnionWith(newCountries);
            display(countries);

            //IntersectWith
            Console.WriteLine("------IntersectWith------");
            HashSet<string> visitedCountries = new HashSet<string>() { "Egypt", "Japan", "Italy" };
            countries.IntersectWith(visitedCountries);
            display(countries);

            //Set operations
            HashSet<int> firstNumbers = new HashSet<int>() { 1, 2, 3, 4, 5 };
            HashSet<int> secondNumbers = new HashSet<int>() { 4, 5, 6, 7 };

            Console.WriteLine("------Set Operations------");

            //ExceptWith
            firstNumbers.ExceptWith(secondNumbers);
            Console.WriteLine("After ExceptWith:");
            display(firstNumbers);

            //Overlaps
            Console.WriteLine($"Overlaps: {firstNumbers.Overlaps(secondNumbers)}");

            //Clear
            Console.WriteLine("------Clear------");
            numbers.Add(10);
            numbers.Add(20);
            numbers.Clear();
            Console.WriteLine($"Numbers Count after Clear: {numbers.Count}");
        }

        //Display HashSet
        static void display(HashSet<string> set)
        {
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }

        static void display(HashSet<int> set)
        {
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
