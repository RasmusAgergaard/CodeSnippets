using System;

namespace Delegates4
{
    public enum operations { Add, Sub, Mul, Div}

    public class MathClass
    {
        public delegate int PointerMaths(int a, int b);

        public PointerMaths GetPointer(operations operation)
        {
            PointerMaths pointerMaths = null;

            switch (operation)
            {
                case operations.Add:
                    pointerMaths = Add;
                    break;
                case operations.Sub:
                    pointerMaths = Sub;
                    break;
                case operations.Mul:
                    pointerMaths = Mul;
                    break;
                case operations.Div:
                    pointerMaths = Div;
                    break;
                default:
                    break;
            }

            return pointerMaths;
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static int Sub(int a, int b)
        {
            return a - b;
        }

        private static int Mul(int a, int b)
        {
            return a * b;
        }

        private static int Div(int a, int b)
        {
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var mathClass = new MathClass();

            Console.WriteLine(mathClass.GetPointer(operations.Add).Invoke(5, 5));       //Output: 10
            Console.WriteLine(mathClass.GetPointer(operations.Sub).Invoke(5, 5));       //Output: 0
            Console.WriteLine(mathClass.GetPointer(operations.Mul).Invoke(5, 5));       //Output: 25
            Console.WriteLine(mathClass.GetPointer(operations.Div).Invoke(5, 5));       //Output: 1

        }
    }
}
