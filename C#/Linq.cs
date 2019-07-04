using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Remove duplicates using a LINQ query
            int[] numbers = { 9, 4, 5, 3, 6, 2, 3, 2, 4, 6, 8, 7, 6, 1, 2, 3, 4, 6, 7, 8, 9, 0, 0 };
            int[] numbersWithoutDuplicates = numbers.Distinct().ToArray();

            foreach (var number in numbersWithoutDuplicates)
            {
                Console.Write(number);                                      //Output: 9453628710
            }

            //Create a CSV like string from a collection using LINQ to Objects
            string[] names = { "Bill", "Phill", "Mill", "Chill", "Bob" };
            string namesCsv = string.Join(",", names);
            Console.WriteLine(namesCsv);                                    //Output: Bill,Phill,Mill,Chill,Bob

            //Sort a collection using LINQ
            List<int> numbers2 = new List<int> { 5, 6, 7, 3, 7, 8, 0, 9, 0, 3, 4, 5, 4, 1 ,2};
            IEnumerable<int> sortedEnum = numbers2.OrderBy(n => n);
            List<int> sortedList = sortedEnum.ToList();

            foreach (var number in sortedList)
            {
                Console.Write(number);                                      //Output: 001233445567789
            }
        }
    }
}
