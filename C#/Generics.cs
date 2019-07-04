using System;
using System.Collections.Generic;

namespace Generics
{
    //Generic linked-list class for demonstration purposes
    public class GenericList<T>
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

        public GenericList()
        {
            _head = null;
        }

        public void AddHead(T type)
        {
            Node node = new Node(type);
            node.Next = _head;
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Example with list of ints
            var intList = new GenericList<int>();

            for (int i = 0; i < 10; i++)
            {
                intList.AddHead(i);
            }

            foreach (var item in intList)
            {
                Console.Write(item + " ");                      //Output: 9 8 7 6 5 4 3 2 1 0
            }

            Console.WriteLine("\n"); //Spacer

            //Example with list of strings
            var stringList = new GenericList<string>();

            for (int i = 0; i < 10; i++)
            {
                stringList.AddHead("Bill");
            }

            foreach (var item in stringList)
            {
                Console.Write(item + " ");                      //Output: Bill Bill Bill Bill Bill Bill Bill Bill Bill Bill
            }

            Console.WriteLine("\n"); //Spacer
        }
    }
}
