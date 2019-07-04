using System;

namespace DelegatesMulticastExample
{
    delegate void CustomDel(string s);

    class Program
    {
        static void Hello(string s)
        {
            Console.Write($"Hello, {s}! ");
        }

        static void Goodbye(string s)
        {
            Console.Write($"Goodbye, {s}! ");
        }

        static void Main(string[] args)
        {
            CustomDel hiDel, byeDel, multiDel, multiMinusHiDel;

            hiDel = Hello;
            byeDel = Goodbye;
            multiDel = hiDel + Goodbye;
            multiMinusHiDel = multiDel - hiDel;

            hiDel("Bill");                      //Output: Hello, Bill!
            Console.WriteLine("");
            byeDel("Bill");                     //Output: Goodbye, Bill!
            Console.WriteLine("");
            multiDel("Bill");                   //Output: Hello, Bill! Goodbye, Bill!
            Console.WriteLine("");
            multiMinusHiDel("Bill");            //Output: Goodbye, Bill!
        }
    }
}
