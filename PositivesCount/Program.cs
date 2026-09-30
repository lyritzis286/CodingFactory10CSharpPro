namespace PositivesCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Εισαγετε εναν αριθμο:");

            while(int.TryParse(Console.ReadLine(), out int number) && number != 0)
            {
                if (number > 0)
                {
                    count++;
                }
                Console.WriteLine("Εισαγετε εναν αριθμο:");


            }
            Console.WriteLine("Ο αριθμος των θετικων αριθμων ειναι: {0}", count);
        }
    }
}
