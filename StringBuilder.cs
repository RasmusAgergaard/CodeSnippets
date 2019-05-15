using System;
using System.Text;

namespace StringAndStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringBuilder = new StringBuilder("Hello World!", 10);
            Console.WriteLine($"{stringBuilder} ({stringBuilder.Capacity})");          //Output: Hello World! (12)
            stringBuilder.Append(" I am Bill");
            Console.WriteLine($"{stringBuilder} ({stringBuilder.Capacity})");          //Output: Hello World! I am Bill (24)
            stringBuilder.Insert(6, "cruel ");
            Console.WriteLine($"{stringBuilder} ({stringBuilder.Capacity})");          //Output: Hello cruel World! I am Bill (30)
            stringBuilder.Remove(0, 6);
            Console.WriteLine($"{stringBuilder} ({stringBuilder.Capacity})");          //Output: cruel World! I am Bill (24)
            stringBuilder.Replace("r", "e");
            Console.WriteLine($"{stringBuilder} ({stringBuilder.Capacity})");          //Output: ceuel Woeld! I am Bill (24)

            var price = 25;
            var stringBuilder2 = new StringBuilder("Your total is ");
            stringBuilder2.AppendFormat("{0:C}", price); //Composite Formatting
            Console.WriteLine(stringBuilder2);                                          //Output: Your total is 25,00 kr.
        }
    }
}
