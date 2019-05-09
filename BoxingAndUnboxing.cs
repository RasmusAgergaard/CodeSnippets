using System;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintVal(100);      //Implisit boxing
            object x = 200;     //Explisit boxing
            PrintVal(x);

            AddOne(x);
        }

        static void PrintVal(object obj)
        {
            Console.WriteLine(obj.ToString());
        }

        static void AddOne(object obj)
        {
            //Unboxing needed, to be able to add 1 to the object
            //Unboxing is alwas Explisit
            Console.WriteLine((int)obj + 1); 
        }
    }
}
