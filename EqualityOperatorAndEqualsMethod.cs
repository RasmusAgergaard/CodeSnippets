using System;

namespace EqualityOperatorAndEqualsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Bill";
            string name2 = name1;

            Console.WriteLine(name1 == name2);                          //Output: True
            Console.WriteLine(name1.Equals(name2));                     //Output: True

            object name11 = "Bill";
            char[] values = new char[] { 'B', 'i', 'l', 'l' };
            object name22 = new string(values);

            Console.WriteLine(name11 == name22);                          //Output: False
            Console.WriteLine(name11.Equals(name22));                     //Output: True
        }
    }
}
