using System;

namespace Interfaces
{
    public enum customerType { Potential, New, Impulsive, Discount, Loyal }

    interface ICustomer
    {
        customerType Type { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        int NumberOfPurchases { get; set; }

        void AddPurchase(int number);
    }

    public class Customer : ICustomer
    {
        public Customer(customerType type, string name, int age)
        {
            Type = type;
            Name = name;
            Age = age;

            Console.WriteLine($"{Type} customer created - {Name}, {Age}");
        }

        public customerType Type { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfPurchases { get; set; }

        public void AddPurchase(int number)
        {
            NumberOfPurchases += number;
            Console.WriteLine($"{Name} has bought {number} items - Total is now: {NumberOfPurchases}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customer1 = new Customer(customerType.New, "Steve", 25);
            var customer2 = new Customer(customerType.Loyal, "Meve", 18);
            var customer3 = new Customer(customerType.Impulsive, "Phill", 45);

            customer1.AddPurchase(3);
            customer1.AddPurchase(5);
            customer2.AddPurchase(6);
            customer3.AddPurchase(12);
            customer3.AddPurchase(8);
        }
    }
}
