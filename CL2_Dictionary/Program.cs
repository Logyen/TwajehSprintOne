using System.Text;

namespace Dictionary_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Capitals = new Dictionary<string, string>();
            Dictionary<int, string> employees = new Dictionary<int, string>()
            {
                {1, "James" },
                {2, "David" },
                {3, "Mark" }
            };
            var fruits = new Dictionary<string, int>()
            {
                {"Apple", 7},
                {"Banana",8 },
                {"Watermelon", 1 }
            };
            var exchangeRate = new Dictionary<string, Double>()
            {
                ["USD"] = 50.00,
                ["EUR"] = 45.00
            };

            //Adding Elments 
            Capitals.Add("Egypt", "Cairo");
            Capitals.Add("Italy", "Roma");
            Capitals.Add("Russia", "Moscow");
            Capitals.Add("Spain", "Madrid");
            Capitals.Add("Germany", "Berlin");
            Capitals.Add("France", "Paris");
            Capitals.Add("England", "London");
            //Display Elments
            foreach (var capital in Capitals)
            {
                Console.WriteLine($"Key {capital.Key}, Value {capital.Value}");
            }
            for (int i = 0; i < Capitals.Count; i++)
            {
                Console.WriteLine(Capitals[Capitals.Keys.ElementAt(i)]);
            }

            //creating new dictionary from exiting one
            var newDictinary = new Dictionary<string, string>(Capitals);

            DisplayDictionary(newDictinary);

            var anotherDictinary = Capitals.ToDictionary(e => e.Key, e => e.Value);

            Console.WriteLine("---------another Dictionary--------");
            DisplayDictionary(anotherDictinary);


            //Access modify
            Console.WriteLine("------Access and Modify-------");

            Console.WriteLine(Capitals["Italy"]);
            Capitals["Italy"] = "venice";
            Console.WriteLine(Capitals["Italy"]);

            //Try Get Value
            Console.WriteLine("------Try and Get-------");
            Capitals.TryGetValue("Usa", out string? searchResult);
            if (searchResult != null)
                Console.WriteLine(searchResult);
            else
                Console.WriteLine("Keys does not exist");

            //Remove
            Console.WriteLine("------Remove------");
            Console.WriteLine(Capitals.Count);
            Console.WriteLine("After Removing");
            Capitals.Remove("Russia");
            Console.WriteLine(Capitals.Count);
            DisplayDictionary(Capitals);


            //Remove all
            Console.WriteLine("------Remove All------");
            Console.WriteLine(Capitals.Count);
            Console.WriteLine("After Removing all");
            //Capitals.Clear();
            Console.WriteLine(Capitals.Count);
            DisplayDictionary(Capitals);

            //contains
            Console.WriteLine("------Contain------");
            Console.WriteLine(Capitals.ContainsKey("France"));
            Console.WriteLine(Capitals.ContainsKey("Spain"));

            Console.WriteLine(Capitals.ContainsValue("Egypt"));
            Console.WriteLine(Capitals.ContainsValue("Madrid"));


            //Duplicate Keys
            string newCountary = "Spain";
            string newCapital = "Madrid";
            int index = Array.IndexOf(Capitals.Keys.ToArray(), newCountary);
            try
            {
                Capitals.Add(newCountary, newCapital);
                DisplayDictionary(Capitals);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Duplicate Found! at index number :" + index);
            }
            DisplayDictionary(Capitals);

            //Ordering 
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("\nOrdering a Dictionary By Key ASC\n");
            var orderByKey = Capitals.OrderBy(x => x.Value);
            foreach (var order in orderByKey)
            {
                Console.WriteLine($"Key {order.Key}, Value {order.Value}");
            }

            //Converting
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("\nConvert a Dictionary to a String\n");
            StringBuilder sb = new StringBuilder();
            foreach (var item in Capitals)
            {
                sb.Append($"{item.Key}: {item.Value} ");
            }
            string finalString = sb.ToString();
            Console.WriteLine(finalString);


            Console.ReadLine();
            void DisplayDictionary(Dictionary<string, string> dictionary)
            {
                foreach (var kvp in dictionary)
                {
                    Console.WriteLine($"Key {kvp.Key} - Value {kvp.Value}");
                }
            }

        }
    }
}