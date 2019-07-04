using System;

namespace Delegates4
{
    public enum operations { Add, Sub, Mul, Div, All}

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
                case operations.All:
                    pointerMaths += Add;
                    pointerMaths += Sub;
                    pointerMaths += Mul;
                    pointerMaths += Div;
                    break;
                default:
                    break;
            }

            return pointerMaths;
        }

        private static int Add(int a, int b)
        {
            Console.Write("Add called ");
            return a + b;
        }

        private static int Sub(int a, int b)
        {
            Console.Write("Sub called ");
            return a - b;
        }

        private static int Mul(int a, int b)
        {
            Console.Write("Mul called ");
            return a * b;
        }

        private static int Div(int a, int b)
        {
            Console.Write("Div called ");
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var mathClass = new MathClass();

            Console.WriteLine(mathClass.GetPointer(operations.Add).Invoke(5, 5));       //Output: Add called 10
            Console.WriteLine(mathClass.GetPointer(operations.Sub).Invoke(5, 5));       //Output: Sub called 0
            Console.WriteLine(mathClass.GetPointer(operations.Mul).Invoke(5, 5));       //Output: Mul called 25
            Console.WriteLine(mathClass.GetPointer(operations.Div).Invoke(5, 5));       //Output: Div called 1

            mathClass.GetPointer(operations.All).Invoke(5, 5);                          //Output: Add called Sub called Mul called Div called
        }
    }
}
