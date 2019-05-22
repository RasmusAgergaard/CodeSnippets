using System;
using System.Collections;

namespace IEnumerableExample
{
    //Simple business object
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    //Collection of Person objects. This class implements IEnumerable so that it can be used with ForEach syntax.
    public class People : IEnumerable
    {
        private Person[] _people;

        public People(Person[] personArray)
        {
            _people = new Person[personArray.Length];

            for (int i = 0; i < personArray.Length; i++)
            {
                _people[i] = personArray[i];
            }
        }

        //GetEnumerator method required by the interface
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }

    //When you implement IEnumerable, you must also implement IEnumerator
    public class PeopleEnum : IEnumerator
    {
        private Person[] _people;

        int position = -1;

        public PeopleEnum(Person[] list)
        {
            _people = list;
        }

        public bool MoveNext()
        {
            position++;
            return position < _people.Length;
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Person Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch(IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[]
            {
                new Person("Bill", "Gates"),
                new Person("Phill", "Gates"),
                new Person("Mill", "Gates")
            };

            var peopleList = new People(peopleArray);

            foreach (var person in peopleList)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");             //Output: Bill Gates
            }                                                                           //        Phill Gates  
        }                                                                               //        Mill Gates
    }
}
