namespace NumberRead
{
    /// <summary>
    /// Safe reading float double from console input.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            float floatNum = 0F;
            double doubleNum = 0D;

            Console.WriteLine("Εισάγετε δυο δεκαδικους");

            if(!float.TryParse(Console.ReadLine(), out floatNum))
            {
                Console.WriteLine("Invalid float number.");
                return;
            }
            
            if(!double.TryParse(Console.ReadLine(), out doubleNum))
            {
                Console.WriteLine("Invalid double number.");
                return;
            }

            Console.WriteLine($"ο δεκαδικος αριθμος float ειναι: {floatNum, -10:N2}");
            Console.WriteLine($"ο δεκαδικος αριθμος double ειναι : {doubleNum, -10:N2}");

        }
    }
}
