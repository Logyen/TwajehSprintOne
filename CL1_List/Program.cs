namespace GenericsList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating 
            List<string> CountrayList = new List<string>();
            var employees = new List<string>() { "Ahmed Mostafa", "Logyen Osama", "Mohamed ALi" };
            List<int> numbers = new List<int>();

            //Add elements 
            CountrayList.Add("Egypt");
            CountrayList.Add("Moraco");
            CountrayList.Add("Argantin");
            CountrayList.Add("Aspin");
            CountrayList.Add("USA");

            //Accessing by index 
            Console.WriteLine($"First element of list is {CountrayList[0]}");
            Console.WriteLine($"Second element of list is {CountrayList[1]}");
            Console.WriteLine($"Last element of list is {CountrayList[CountrayList.Count - 1]}");

            //Itrate through list 
            for (int i = 0; i < CountrayList.Count; i++)
            {
                Console.WriteLine(CountrayList[i]);
            }
            // Foreach
            foreach (var countary in CountrayList)
            {
                Console.WriteLine(countary);
            }

            //Add to list
            CountrayList.Add("Zombia");
            CountrayList.Add("Jordon");

            // Insert Elment in the list 
            CountrayList.Insert(0, "Jaban");
            CountrayList.Insert(1, "Azribjian");
            CountrayList.Insert(5, "Usa");
            CountrayList.Insert(4, "Usa");

            Console.WriteLine("--------Insert List-------");
            display();

            //Removing List
            Console.WriteLine("------Removing List ----------");
            CountrayList.Remove("Jordon");
            //CountrayList.RemoveAll("Usa");
            display();

            //Change elment in List
            Console.WriteLine("------Change Elment in list-------");
            CountrayList[2] = "Korea";
            display();
            Console.WriteLine($"Count: {CountrayList.Count}");
            //Copying List
            Console.WriteLine("------Copying List ----------");
            string[] copied = new string[10];
            CountrayList.CopyTo(copied);
            collection.Display(copied);


            //Displayig list 

            Console.WriteLine("------ Displaying List ----------");
            collection.DisplayList(CountrayList);

            //Sorting List
            Console.WriteLine("------Sorting List ----------");
            CountrayList.Sort();
            collection.DisplayList(CountrayList);

            //Reversing List
            Console.WriteLine("------Reversing List ----------");
            CountrayList.Reverse();
            collection.DisplayList(CountrayList);

            void display()
            {
                foreach (var countary in CountrayList)
                {
                    Console.WriteLine(countary);
                }
            }
        }
        public class collection
        {
            public static void Display(string[] array)
            {
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
            }
            public static void DisplayList(List<string> list)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}