using System;
using System.Collections.Generic;

namespace GenericsConstraintsExample
{
    public class Employee
    {
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }

    //The constraint specifies that all items of type T are guaranteed to be either an Employee object 
    //or an object that inherits from Employee
    public class GenericList<T> where T : Employee
    {
        private class Node
        {
            public Node(T type)
            {
                Next = null;
                Data = type;
            }

            public Node Next { get; set; }
            public T Data { get; set; }
        }

        private Node _head;

        public void AddHead(T type)
        {
            var node = new Node(type) { Next = _head};
            _head = node;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = _head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public T FindFirstOccurrence(string str)
        {
            Node current = _head;
            T type = null;

            while (current != null)
            {
                //The constraint enables access to the Name property
                if (current.Data.Name == str)
                {
                    type = current.Data;
                    break;
                }
                else
                {
                    current = current.Next;
                }
            }

            return type;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var employeeList = new GenericList<Employee>();

            for (int i = 0; i < 10; i++)
            {
                employeeList.AddHead(new Employee(i, "Bill" + i));
            }

            foreach (var employee in employeeList)
            {
                Console.Write($"{employee.Name} ");                             //Output: Bill9 Bill8 Bill7 Bill6 Bill5 Bill4 Bill3 Bill2 Bill1 Bill0
            }

            Console.WriteLine("\n"); //Spacer

            var result = employeeList.FindFirstOccurrence("Bill3");
            Console.WriteLine(result.Name);                                     //Output: Bill3
        }
    }
}
