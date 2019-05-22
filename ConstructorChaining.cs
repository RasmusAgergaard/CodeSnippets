using System;

namespace ConstructorChaining
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int NumberOfStuff1 { get; set; }
        public int NumberOfStuff2 { get; set; }

        //Constructor chaining 1
        public Person(int age, string name, int numberOfStuff1) : this(age, name)
        {
            NumberOfStuff1 = numberOfStuff1;
        }

        //constructor chaining 2
        public Person(int age, string name, int numberOfStuff1, int numberOfStuff2) : this(age, name, numberOfStuff1)
        {
            NumberOfStuff2 = numberOfStuff2;
        }

        //Default constructor 
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }

    public class UserLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }

        public UserLogin(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public UserLogin(string username, string password, string type) : this(username, password)
        {
            Type = type;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person(34, "Bill");                               //Calls the default constructor
            var person2 = new Person(34, "Bill", 45);                           //Calls constructor chaining 1
            var person3 = new Person(34, "Bill", 45, 85);                       //Calls constructor chaining 2

            var user1 = new UserLogin("bill@gates.com", "appel");               //Calls the defualt constructor
            var user2 = new UserLogin("bill@gates.com", "appel", "Customer");   //Calls the chained constructor
        }
    }
}
