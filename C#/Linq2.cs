using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ query expression example
            int[] scores = new int[] { 45, 56, 78, 89, 45, 12, 35, 85, 21, 66, 99, 68 };

            //Define the query expression
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 60
                orderby score
                select score;

            //Execute the query
            foreach (var score in scoreQuery)
            {
                Console.WriteLine(score + " ");
            }
        }
    }
}
