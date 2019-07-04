using System;

namespace Partial
{
    //Partial class definition
    public partial class Coords
    {
        private int x;
        private int y;

        public Coords(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    //Another partial class definition
    public partial class Coords
    {
        public void SwitchCoords()
        {
            var temp = x;
            x = y;
            y = temp;
        }
    }

    //Another partial class definition
    public partial class Coords
    {
        public void PrintCoords()
        {
            Console.WriteLine($"Coords: {x}:{y}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var testCoord = new Coords(240, 852);
            testCoord.PrintCoords();
            testCoord.SwitchCoords();
            testCoord.PrintCoords();
        }
    }
}
