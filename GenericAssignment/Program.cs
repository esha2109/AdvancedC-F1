using System;
using System.Collections.Generic;

namespace GenericAssignment
{
    class Program
    {
//        Write a generic class that meets the following requirements:
//1)    That constrains a developer to only instantiate the class based on value types
//2)    Contains a private generic collection
//3)    Has a method to add items to the private collection
//4)    Has a method that will return an item from the list(e.g.item 3 or item 4 in the list)
//5)    Has a method that returns a sorted collection with the items in descending order
        static void Main(string[] args)
        {
            GenericCollection<int> q1 = new GenericCollection<int>();
            q1.Add(1);
            q1.Add(2);
            q1.Add(3);
            q1.Add(4);

            q1.Display();

        }
    }
    class GenericCollection<T> where T : struct
    {
        private T[] _items = new T[50];

        private int _numitems = 0;

        public void Add(T item)
        {
            if (_numitems + 1 < 50)
            {
                _items[_numitems] = item;
                _numitems++;
            }
        }
        public void Display()
        {
            foreach (T x in _items)
            {
                Console.WriteLine(x);
            }
        }

    }
}
