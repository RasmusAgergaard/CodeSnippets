using System;

namespace StringAndStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chars
            char[] chars = { 'A', 'B', 'C', 'D' };
            string charsCombined = new string(chars);
            Console.WriteLine(charsCombined);                           //Output: ABCD

            //Combine strings
            var string1 = "Hello ";
            var string2 = "World!";
            string1 += string2;
            Console.WriteLine(string1);                                 //Output: Hello World!

            //Columns and Rows
            string columns = "Item1\tItem2\tItem3";
            Console.WriteLine(columns);                                 //Output: Item1   Item2   Item3

            string rows = "Item1\r\nItem2\r\nItem3";
            Console.WriteLine(rows);

            //Verbatim string example
            string filePath = @"C:\Users\Bill\";                        //Output: C: \Users\Bill\
            Console.WriteLine(filePath);

            string multiLineText = @"Line1 text here
                Line2 text here
                Line3 text here";
            Console.WriteLine(multiLineText);

            //String Interpolation example
            string firstName = "Bill";
            string lastName = "Gates";
            string interpolationText = $"{firstName} is a name, and {lastName} is a lastname";
            Console.WriteLine(interpolationText);                       //Output: Bill is a name, and Gates is a lastname

            //Composite Formatting example
            string compositeText = string.Format("{0} is a name, and {1} is a lastname", firstName, lastName);
            Console.WriteLine(compositeText);                           //Output: Bill is a name, and Gates is a lastname

            //Substring example
            string textExample = "You can call me cookie";
            Console.WriteLine(textExample.Substring(10));               //Output: ll me cookie
            Console.WriteLine(textExample.Substring(16, 4));            //Output: cook
            Console.WriteLine(textExample.Replace("cookie", "Bill"));   //Output: You can call me Bill
            int index = textExample.IndexOf("c");                       //index = 4

            //Read-only access to individual characters
            for (int i = 0; i < textExample.Length; i++)
            {
                Console.Write(textExample[textExample.Length - i - 1]); //Output: eikooc em llac nac uoY
            }
            Console.WriteLine(""); //Line break

            //Null Strings and Empty Strings example
            string strNull = null;                                      //Can be used eventhough it's null
            string strEmpty = string.Empty;                             //Contains ""
            Console.WriteLine("Item1" + strNull + "Item2");             //Output: Item1Item2
            Console.WriteLine("Item1" + strEmpty + "Item2");            //Output: Item1Item2
        }
    }
}
