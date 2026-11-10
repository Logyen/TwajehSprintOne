using System;
using System.Collections.Generic;

namespace GenericClassPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating object from Generic Class with string
            Box<string> stringBox = new Box<string>();
            stringBox.Value = "Hello C#";

            Console.WriteLine("------String Box------");
            stringBox.Display();

            //Creating object from Generic Class with int
            Box<int> numberBox = new Box<int>();
            numberBox.Value = 100;

            Console.WriteLine("------Number Box------");
            numberBox.Display();

            //Creating object from Generic Class with double
            Box<double> priceBox = new Box<double>();
            priceBox.Value = 150.75;
            priceBox.Display();

            //Generic Class with two types
            Pair<string, int> employee = new Pair<string, int>("Logyen", 23);
            employee.Display();

            //Generic Repository
            Repository<string> namesRepository = new Repository<string>();

            //Add elements
            namesRepository.Add("Ahmed");
            namesRepository.Add("Logyen");
            namesRepository.Add("Mohamed");

            //Display elements
            Console.WriteLine("------Repository Items------");
            namesRepository.Display();

            //Access element
            Console.WriteLine($"Item at index 1: {namesRepository.GetByIndex(1)}");

            //Remove element
            Console.WriteLine("------After Remove------");
            namesRepository.Remove("Ahmed");
            namesRepository.Display();

            //Count
            Console.WriteLine($"Count: {namesRepository.Count}");

            //Generic Repository with int
            Repository<int> numbersRepository = new Repository<int>();
            numbersRepository.Add(10);
            numbersRepository.Add(20);
            numbersRepository.Add(30);

            Console.WriteLine("------Numbers Repository------");
            numbersRepository.Display();
        }
    }

    //Generic Class
    public class Box<T>
    {
        public T Value { get; set; }

        public void Display()
        {
            Console.WriteLine($"Value: {Value}");
            Console.WriteLine($"Type: {typeof(T)}");
        }
    }

    //Generic Class with two type parameters
    public class Pair<T, U>
    {
        public T First { get; set; }
        public U Second { get; set; }

        public Pair(T first, U second)
        {
            First = first;
            Second = second;
        }

        public void Display()
        {
            Console.WriteLine($"First: {First}");
            Console.WriteLine($"Second: {Second}");
        }
    }

    //Simple Generic Repository
    public class Repository<T>
    {
        private List<T> items = new List<T>();

        public int Count
        {
            get { return items.Count; }
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public T GetByIndex(int index)
        {
            return items[index];
        }

        public void Display()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
