using System.Text;

namespace ExtractCapitals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static string ExtractCapitals(string? s)
        {
            if (s is null)
            {
                return string.Empty;
            }
            StringBuilder sb = new StringBuilder();

            // char.IsUpper -> true/false

            foreach (char c in s)
            {
                if (char.IsUpper(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
