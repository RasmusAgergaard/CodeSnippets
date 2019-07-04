using System;

namespace GenericMethodsExample
{
    class Program
    {
        static void Swap<T> (ref T item1, ref T item2)
        {
            T temp = item1;
            item1 = item2;
            item2 = temp;
        }

        static void Main(string[] args)
        {
            // ************ Example 1 ************ //
            int a = 1;
            int b = 2;

            Console.WriteLine($"a:{a} - b:{b}");                  //Output: a:1 - b:2

            //The type argument can be omitted - Swap<int>(ref a, ref b);
            Swap(ref a, ref b);

            Console.WriteLine($"a:{a} - b:{b}");                  //Output: a:2 - b:1


            // ************ Example 2 ************ //
            string name1 = "Bill Gates";
            string name2 = "Phill Gates";

            Console.WriteLine($"{name1} & {name2}");            //Output: Bill Gates & Phill Gates

            Swap(ref name1, ref name2);

            Console.WriteLine($"{name1} & {name2}");            //Output: Phill Gates & Bill Gates
        }
    }
}
