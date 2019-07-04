using System;

namespace ArraysAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Size of grid
            int numberOfColumns = 3;
            int numberOfRows = 3;

            //Multidimensional Array
            int[,] array2D = new int[numberOfColumns, numberOfRows];


            //Add numbers to array
            int numberToAdd = 1;

            for (int column = 0; column < numberOfColumns; column++)
            {
                for (int row = 0; row < numberOfRows; row++)
                {
                    array2D[column, row] = numberToAdd;
                    numberToAdd++;
                }
            }

            //Output array content
            for (int column = 0; column < numberOfColumns; column++)
            {
                for (int row = 0; row < numberOfRows; row++)   
                {
                    Console.Write(array2D[column, row]);
                }

                //Add line break after each row
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
