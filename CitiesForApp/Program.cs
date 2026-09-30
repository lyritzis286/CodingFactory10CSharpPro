namespace CitiesForApp
{
    /// <summary>
    /// 
    ///FOR CONTROL STRACTURE
    ///DEMONSTRATION PURPOSES ONLY
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Athens", "Thesaloniki", "Patras", "Heraklion" };

            for (int i = 0; i< cities.Length; i++)
            {
                if (cities[i] == "Patras")
                {
                    Console.WriteLine($"Found {cities[i]} at index {i}");
                        break;
                }
            }

            foreach (string city in cities)
            {
                if (city == "Heraklion")
                {
                    Console.WriteLine($"Found {city} in the list");
                    break;
                }
            }
        }
    }
}
