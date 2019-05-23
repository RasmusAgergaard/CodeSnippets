using System;

namespace AbstractExample
{
    public abstract class Shape
    {
        //Cannot declare a body because it is marked abstract
        public abstract int GetArea();
    }

    public class Square : Shape
    {
        private int _side;

        public Square(int side)
        {
            _side = side;
        }

        public override int GetArea()
        {
            var result = _side * _side;
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(24);
            Console.WriteLine(square.GetArea());                                //Output: 576
        }
    }
}
