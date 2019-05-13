using System;

namespace Properties
{
    public class TimePeriod
    {
        private double _seconds;

        public double Hours
        {
            get
            {
                return _seconds / 3600;
            }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 24");
                }

                _seconds = value * 3600;
            }
        }
    }

    public class Person
    {
        //Fields
        private string _firstName;
        private string _lastName;

        //Constructor
        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        //Read-only Name property as an expression-bodied member
        public string Name => $"{_firstName} {_lastName}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            var timePeriod = new TimePeriod();
            timePeriod.Hours = 18;
            Console.WriteLine(timePeriod.Hours);

            var person = new Person("Bill", "Gates");
            Console.WriteLine(person.Name);
        }
    }
}
