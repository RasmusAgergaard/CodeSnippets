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

    public class SaleItem
    {
        //Expression body definitions for both accessors
        //Note that the return keyword is not used with the get accessor

        private string _name;
        private decimal _cost;

        public SaleItem(string name, decimal cost)
        {
            _name = name;
            _cost = cost;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public decimal Price
        {
            get => _cost;
            set => _cost = value;
        }
    }

    public class SaleItem2
    {
        //Auto-implemented properties
        public string Name { get; set; }
        public decimal Price { get; set; }
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

            var item = new SaleItem("Shoes", 19.95m);
            Console.WriteLine($"{item.Name}: sells for {item.Price}");

            //Object is initialized with a object initializer
            var item2 = new SaleItem2 { Name = "Plant", Price = 9.99m };
            Console.WriteLine($"{item2.Name}: sells for {item2.Price}");
        }
    }
}
