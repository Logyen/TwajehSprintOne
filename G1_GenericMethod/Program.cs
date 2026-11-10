using System;
using System.Collections.Generic;

namespace GenericMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling Generic Method with string
            Display("Hello C#");

            //Calling Generic Method with int
            Display(100);

            //Calling Generic Method with double
            Display(10.5);

            //Calling Generic Method with List
            List<string> names = new List<string>() { "Ahmed", "Logyen", "Mohamed" };
            Display(names);

            //Calling Generic Method with two parameters
            PrintData("Age", 23);
            PrintData("Salary", 12000.5);

            //Swap two values
            int firstNumber = 10;
            int secondNumber = 20;

            Console.WriteLine("------Before Swap------");
            Console.WriteLine($"First: {firstNumber}");
            Console.WriteLine($"Second: {secondNumber}");

            Swap(ref firstNumber, ref secondNumber);

            Console.WriteLine("------After Swap------");
            Console.WriteLine($"First: {firstNumber}");
            Console.WriteLine($"Second: {secondNumber}");

            //Get first element from list
            List<int> numbers = new List<int>() { 10, 20, 30, 40 };
            int first = GetFirst(numbers);
            Console.WriteLine($"First Number: {first}");

            //Compare two values
            Console.WriteLine($"Are equal: {AreEqual(10, 10)}");
            Console.WriteLine($"Are equal: {AreEqual("Ahmed", "Logyen")}");
        }

        //Generic Method
        static void Display<T>(T value)
        {
            Console.WriteLine($"Value: {value}");
            Console.WriteLine($"Type: {typeof(T)}");
        }

        //Generic Method with two different types
        static void PrintData<T, U>(T firstValue, U secondValue)
        {
            Console.WriteLine($"{firstValue}: {secondValue}");
        }

        //Swap Method
        static void Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }

        //Return Generic Type
        static T GetFirst<T>(List<T> list)
        {
            return list[0];
        }

        //Generic Method with bool return
        static bool AreEqual<T>(T first, T second)
        {
            return EqualityComparer<T>.Default.Equals(first, second);
        }
    }
}
