using System;

namespace NullableTypes
{
    public class TestClass
    {
        //int number = null;        //Error: Cannot convert null to 'int' because it is a non-nullable value type
        int? number = null;         //Nullable type

        int? x = null;
        int? y = null;

        public void SetValues(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ConverseValues()
        {
            //Using the null-coalescing operator to convert. If the value of x is null, it returns -1
            int newX = x ?? -1; 
            int newY = y ?? -1;
        }

        public void PrintValues()
        {
            if (x.HasValue || y.HasValue)
            {
                Console.WriteLine($"{x.Value}:{y.Value}");
            }
            else
            {
                Console.WriteLine("X or Y has no value");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var testClass = new TestClass();
            testClass.PrintValues();                //Output: X or Y has no value
            testClass.SetValues(100, 200);
            testClass.PrintValues();                //Output: 100:200

            int? a = 100;
            int? b = null;
            a = a + a;          //a is 200
            a = a + b;          //a is null

            //Box/Unbox example
            int aa = 41;
            object aaBoxed = aa;
            int? aaNullable = (int)aaBoxed;
            Console.WriteLine($"Value of aaNullable: {aaNullable}");                //Output: 41

            object aaNullableBoxed = aaNullable;
            if (aaNullableBoxed is int valueOfA)
            {
                Console.WriteLine($"aaNullableBoxed is boxed int: {valueOfA}");     //Output: 41
            }
        }
    }
}
