using System;

namespace ExtensionMethods
{
    public static class StringExtension
    {
        public static bool IsNumeric(this string str)
        {
            double output; //The output is not used
            return double.TryParse(str, out output);
        }

        public static int WordCount(this string str)
        {
            char[] delimiterChars = { ' ', '.', '?' };
            int numberOfWOrds = str.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries).Length;
            return numberOfWOrds;

            //Can be "one-lined" like this:
            //return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    public static class IntegerExtensions
    {
        public static bool IsEven(this int i)
        {
            bool isEven = (i % 2) == 0; //Remainder operator is used
            return isEven;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //String 1
            string str = "100";
            if (str.IsNumeric())
            {
                Console.WriteLine($"The string object '{str}' is numeric");
            }

            //String 2
            string str2 = "This is test to see if WordCount works";
            Console.WriteLine($"Word count: {str2.WordCount()}");

            //Int
            int number = 22;
            if (number.IsEven())
            {
                Console.WriteLine($"{number} is even");
            }
        }
    }
}
