namespace LinqArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {5, 3, 1, 4, 2, 10 };

            int min = arr.Min();
            Console.WriteLine($"The minimum value is: {min}");
            int max = arr.Max();

            int sum = arr.Sum();
            double average = arr.Average();
            int count = arr.Count(); //int count = arr.Length; // alternative way to get the count
            int countFT4 = arr.Count(x => x > 4); // count of elements greater than 4

            var filtered = arr.Where(x => x > 4).ToArray(); // filter elements greater than 4

        }
    }
}
