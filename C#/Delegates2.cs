using System;
using System.Collections.Generic;

namespace Delegates2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        //Delegate
        public delegate bool FilterDelegate(Person person);

        //Method that uses the delegate
        //Note: 'static' is used so I don't haft to create an instance of 'Program'
        public static void DisplayPeople(string title, List<Person> list, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach (var person in list)
            {
                if (filter(person))
                {
                    Console.WriteLine($"{person.Name} is {person.Age} years old");
                }
            }

            Console.WriteLine("");
        }

        //Filter methods
        private static bool IsChild(Person person)
        {
            return person.Age < 18;
        }

        private static bool IsAdult(Person person)
        {
            return person.Age >= 18;
        }

        private static bool IsSenior(Person person)
        {
            return person.Age >= 65;
        }

        static void Main(string[] args)
        {
            //Create persons and add them to a list
            var person1 = new Person { Name = "Bill", Age = 35 };
            var person2 = new Person { Name = "Phill", Age = 72 };
            var person3 = new Person { Name = "Murray", Age = 48 };
            var person4 = new Person { Name = "Tom", Age = 8 };
            var listOfPeople = new List<Person> { person1, person2, person3, person4 };

            //Invoke DisplayPeople using appropriate delegate
            DisplayPeople("Children:", listOfPeople, IsChild);
            DisplayPeople("Adults:", listOfPeople, IsAdult);
            DisplayPeople("Seniors:", listOfPeople, IsSenior);
        }
    }
}
