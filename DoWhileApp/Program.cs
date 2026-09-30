namespace DoWhileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int numberOfDigits = 0;
            int tmp = 0;

            Console.WriteLine("Please enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out num)) ;
            {
                Console.WriteLine("Μη εγκυρη εισοδος. Παρακαλω εισαγετε εναν ακεραιο ");
                return;

            }

            tmp = num;
            do
            {
                tmp /= 10;
                numberOfDigits++;

            } while (tmp != 0);
            Console.WriteLine($"Ο ΑΡΙΘΜΟΣ {num} εχει {numberOfDigits} ψηφια");
        }
    }
}
