using System.Collections.Generic;
using System.Linq;

namespace Linq3
{
    public enum customerTypes { New, Repeating, Discount, Bad }

    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public customerTypes Type { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer() { Id = 1, FirstName = "Bill", LastName = "Gates", Type = customerTypes.New },
                new Customer() { Id = 2, FirstName = "Phill", LastName = "Nielson", Type = customerTypes.Repeating },
                new Customer() { Id = 3, FirstName = "Rob", LastName = "Robson", Type = customerTypes.Bad },
                new Customer() { Id = 4, FirstName = "Sam", LastName = "Wise", Type = customerTypes.New },
                new Customer() { Id = 5, FirstName = "Abe", LastName = "Jackson", Type = customerTypes.Discount }
            };

            //Creating the query
            IEnumerable<Customer> newCustomers =
                from customer in customers
                where customer.Type == customerTypes.New
                orderby customer.Id
                select customer;

            //Executing the query
            foreach (var customer in newCustomers)
            {
                System.Console.WriteLine(customer.FirstName);                   //Outputs Bill and Sam
            }

            //New query, all customers orderby firstname
            IEnumerable<Customer> allCustomers =
                from customer in customers
                orderby customer.FirstName
                select customer;

            foreach (var customer in allCustomers)
            {
                System.Console.Write(customer.FirstName + " ");                 //Output: Abe Bill Phill Rob Sam
            }
        }
    }
}
