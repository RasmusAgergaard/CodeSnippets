using System;
using System.Collections.Generic;

namespace List
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<int>();
            list1.Add(3);
            list1.Add(3);
            list1.Add(8);
            Console.WriteLine($"{list1[0]}{list1[1]}{list1[2]}");               //Output: 338

            //Using object initializer syntax
            var list2 = new List<Person>()
            {
                new Person(){Id = 1, Name = "Bill"},
                new Person(){Id = 2, Name = "Phill"},
                new Person(){Id = 3, Name = "Mike"}
            };

            list2.Insert(2, new Person() { Name = "Paul" });

            foreach (var person in list2)
            {
                Console.Write(person.Name);                                     //Output: BillPhillPaulMike
            }

            Console.WriteLine(""); //Spacer

            var result1 = list2.Find(x => x.Name.Contains("Mike"));
            Console.WriteLine($"{result1.Id} {result1.Name}");                  //Output: 3 Mike

            var result2 = list2.Exists(x => x.Id == 2);
            Console.WriteLine(result2);                                         //Output: True  

            Console.WriteLine(list2.Capacity);                                  //Output: 4
            list2.Add(new Person() { Name = "Ole" });
            Console.WriteLine(list2.Capacity);                                  //Output: 8
        }
    }
}
