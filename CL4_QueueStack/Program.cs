using System;
using System.Collections.Generic;

namespace QueueStackPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ================= Queue =================

            //Creating Queue
            Queue<string> customers = new Queue<string>();
            var names = new Queue<string>(new string[] { "Ahmed", "Logyen", "Mohamed" });

            //Add elements
            customers.Enqueue("Ahmed");
            customers.Enqueue("Logyen");
            customers.Enqueue("Mohamed");
            customers.Enqueue("Sara");

            //Access first element
            Console.WriteLine($"First customer: {customers.Peek()}");

            //Count elements
            Console.WriteLine($"Queue Count: {customers.Count}");

            //Check if element exists
            Console.WriteLine($"Contains Logyen: {customers.Contains("Logyen")}");

            //Iterate through Queue
            Console.WriteLine("------Queue Elements------");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            //Remove first element
            Console.WriteLine("------Dequeue------");
            Console.WriteLine($"Removed: {customers.Dequeue()}");
            displayQueue(customers);

            //TryPeek
            if (customers.TryPeek(out string firstCustomer))
            {
                Console.WriteLine($"Next customer: {firstCustomer}");
            }

            //TryDequeue
            if (customers.TryDequeue(out string removedCustomer))
            {
                Console.WriteLine($"Removed using TryDequeue: {removedCustomer}");
            }

            //Clear Queue
            customers.Clear();
            Console.WriteLine($"Queue Count after Clear: {customers.Count}");


            // ================= Stack =================

            //Creating Stack
            Stack<string> books = new Stack<string>();
            var numbers = new Stack<int>();

            //Add elements
            books.Push("C#");
            books.Push("SQL");
            books.Push("OOP");
            books.Push("LINQ");

            //Access last added element
            Console.WriteLine($"Top book: {books.Peek()}");

            //Count elements
            Console.WriteLine($"Stack Count: {books.Count}");

            //Check if element exists
            Console.WriteLine($"Contains SQL: {books.Contains("SQL")}");

            //Iterate through Stack
            Console.WriteLine("------Stack Elements------");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

            //Remove top element
            Console.WriteLine("------Pop------");
            Console.WriteLine($"Removed: {books.Pop()}");
            displayStack(books);

            //TryPeek
            if (books.TryPeek(out string topBook))
            {
                Console.WriteLine($"Top book now: {topBook}");
            }

            //TryPop
            if (books.TryPop(out string removedBook))
            {
                Console.WriteLine($"Removed using TryPop: {removedBook}");
            }

            //Copying Stack
            string[] copiedBooks = books.ToArray();
            Console.WriteLine("------Copied Stack------");
            foreach (var book in copiedBooks)
            {
                Console.WriteLine(book);
            }

            //Clear Stack
            books.Clear();
            Console.WriteLine($"Stack Count after Clear: {books.Count}");
        }

        static void displayQueue(Queue<string> queue)
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        static void displayStack(Stack<string> stack)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
