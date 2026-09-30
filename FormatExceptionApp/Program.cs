namespace FormatExceptionApp
{
    /// <summary>
    /// Διαβαζει στρινγκ απο την κονσολα και 
    /// προσπαθει να το μετατρεψει σε ακεραιο.
    /// θα ελεγξει με try catch για FormatException
    /// Μην ξεχασετε οτι στην c# δεν υπαρχουν checked kai unchecked exceptions, οποτε δεν μπορειτε να χρησιμοποιησετε throws
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while(true)
            {
                try
                {
                    Console.WriteLine("Παρακαλώ εισάγετε έναν αριθμό:");
                    num = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Ο αριθμός που εισάγατε είναι: {num}");
                    if (num == 0) break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            }
        }
    }

