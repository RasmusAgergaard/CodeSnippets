using System;

namespace Enums
{
    enum weekdays
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
    }

    //When the first value is set, each successive enum member is increased by 1. The default is 0
    enum valueTest
    {
        Item1 = 5,
        Item2,
        Item3
    }

    enum weekdays2
    {
        Monday = 5,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(weekdays.Friday);         //Prints: Friday
            Console.WriteLine((int)weekdays.Friday);    //Prints: 5

            Console.WriteLine((int)valueTest.Item1);    //Prints: 5
            Console.WriteLine((int)valueTest.Item2);    //Prints: 6
            Console.WriteLine((int)valueTest.Item3);    //Prints: 7

            //Explicit cast
            int dayNumber = (int)weekdays.Sunday;
            Console.WriteLine(dayNumber);               //Prints: 7

            //A enum cannot be directly looped through, but the values can be retrived with GetValues
            var arrayOfWeekdays = Enum.GetValues(typeof(weekdays2));
            foreach (var day in arrayOfWeekdays)
            {
                Console.WriteLine("{0} {1}", day, (int)day);  //Prints: Monday 5, Tuesday 6, Wednesday 7...
            }

            //Use GetStrings to retrive the constants, this looses the values
            var arraysOfWeekdays2 = Enum.GetNames(typeof(weekdays2));
            foreach (var day in arraysOfWeekdays2)
            {
                Console.WriteLine(day); //Prints: Monday, Tuesday, Wednesday...
            }   
        }
    }
}
