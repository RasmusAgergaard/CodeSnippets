using System;

namespace Indexers
{
    public class SampleCollection1<T>
    {
        private T[] array = new T[100];

        //Define the indexer to allow client code to use [] notation
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
    }

    public class SampleCollection2<T>
    {
        private T[] array = new T[100];
        private int nextIndex = 0;

        //Define the indexer to allow client code to use [] notation
        //Using the expression body, instead of the get keyword
        public T this[int i] => array[i];

        public void Add(T value)
        {
            if (nextIndex >= array.Length)
            {
                throw new IndexOutOfRangeException($"The collection can hold only {array.Length} elements");
            }

            array[nextIndex++] = value;
        }
    }

    public class TempRecord
    {
        private float[] temps = new float[] { 11.1f, 15.7f, 18.6f, 20.4f, 22.7f };

        //Propperty so the user can validate input
        public int Lenght
        {
            get { return temps.Length; }
        }

        //Indexer declaration
        public float this[int index]
        {
            get
            {
                return temps[index];
            }
            set
            {
                temps[index] = value;
            }
        }
    }

    public class DaysCollection
    {
        private string[] days = new string[] { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat", "Sun" };

        //Method to find the day number. Throws an exception if day is not found
        private int GetDay(string day)
        {
            for (int i = 0; i < days.Length; i++)
            {
                if (days[i] == day)
                {
                    return i;
                }
            }

            throw new ArgumentOutOfRangeException(day, "Could not be found");
        }

        //Indexer declaration
        public int this[string day]
        {
            get
            {
                return GetDay(day);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            var sampleCollection1 = new SampleCollection1<string>();
            sampleCollection1[0] = "Hello Bill";
            Console.WriteLine(sampleCollection1[0]);                                //Output: Hello Bill

            //Example 2
            var sampleCollection2 = new SampleCollection2<string>();
            sampleCollection2.Add("Hello Bill");
            Console.WriteLine(sampleCollection2[0]);                                //Output: Hello Bill

            //Example 3
            var tempRecord = new TempRecord();
            tempRecord[3] = 12.5f; //Using the indexer's set accessor

            //Using the indexer's get accessor
            for (int i = 0; i < tempRecord.Lenght; i++)
            {
                Console.WriteLine($"Item {i} - Has value: {tempRecord[i]}");        //Output: Item 0 - Has value: 11,1
            }

            //Example 4
            var daysCollection = new DaysCollection();
            Console.WriteLine(daysCollection["Mon"]);                               //Output: 0
            Console.WriteLine(daysCollection["Fri"]);                               //Output: 4
            Console.WriteLine(daysCollection["WrongDay"]);                          //Throws ArgumentOutOfRangeException
        }
    }
}
