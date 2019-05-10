using System;

namespace Static
{
    public static class MathStuff
    {
        public static int AddNumbers(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
    }

    public class Customer
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        public static int NumberOfEmployees { get; private set; }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            IncreaseNumberOfEmployees();
        }

        private static void IncreaseNumberOfEmployees()
        {
            NumberOfEmployees++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MathStuff.AddNumbers(48, 48));

            var customer1 = new Customer("Bill", "Gates");
            var customer2 = new Customer("Phill", "Gates");
            var customer3 = new Customer("Matt", "Gates");

            Console.WriteLine("Number of employees: " + Customer.NumberOfEmployees);
        }
    }
}
