namespace FibonacciIterative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"fibonacci(10) = {Fibonacci(10)}");
        }

        public static int Fibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            int a = 0;
            int b = 1;
            int c = 1;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        public static int FibonacciWithArray(int n)
        {
            int[] arr = new int[n + 1];
            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr[n];
        }
    }
}
