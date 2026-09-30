using System.Numerics;

namespace ProductWhileApp
{
    /// <summary>
    /// Υπολογιζει το 1 * 2 *3.... με BigInteger
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const int LIMIT = 100;
            BigInteger result = 1;
            int i = 1;

            while(i <= LIMIT)
            {
                result *= i;
                i++;
            }
            Console.WriteLine($"Το αποτέλεσμα είναι: {result}");
        }
    }
}
