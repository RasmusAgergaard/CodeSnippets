using System;

namespace Struct
{
    public struct Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;
    }

    //Parameterized Constructor
    public struct EmployeeTwo
    {
        public int Id;
        public string FirstName;
        public string LastName;

        public EmployeeTwo(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee(); //The new keyword calls the constructor, and initializes the members to their default value
            Console.WriteLine(employee1.FirstName); //And the members can be accessed without error

            Employee employee2; //Memebers are uninitialized and cannot be accessed

            var employee3 = new EmployeeTwo(10, "Bill", "Gates");
            Console.WriteLine($"ID: {employee3.Id} - Name: {employee3.FirstName} {employee3.LastName}");
        }
    }
}
