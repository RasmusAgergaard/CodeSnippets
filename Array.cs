using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a single-dimensional array
            int[] array1 = new int[5];
            //Declare and set
            int[] array2 = new int[] { 2, 4, 6, 8, 9 };
            int[] array3 = { 2, 4, 6, 8, 9 };

            //Declare a two dimensional array
            int[,] multiDimensionalArray1 = new int[2, 3];
            //Declare and set
            int[,] multiDimensionalArray2 = { { 2, 3, 4, 5 }, { 1, 2, 3, 4, } };

            //Declare a jagged array
            int[][] jaggedArray = new int[6][];
            jaggedArray[0] = new int[] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[] { 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(jaggedArray[0][2]);               //Output: 3
            Console.WriteLine(jaggedArray[1][2]);               //Output: 7
        }
    }
}
