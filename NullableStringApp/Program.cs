namespace NullableStringApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? s = Console.ReadLine(); // Nullable string
           if(s != null) Console.WriteLine(s.Length);

            Console.WriteLine(s?.Length);
            Console.WriteLine(s!.Length);  //null forgiving operator not safe

            Console.WriteLine(s ?? "Default");// null coalescing operator safe


        }
    }
}
