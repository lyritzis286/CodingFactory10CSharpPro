namespace PyramidChallenge
{
    /// <summary>
    /// Ο χρηστη εισαγε το υψος της πυραμιδας 
    /// και το προγραμμα εμφανιζει την πυραμιδα με αστερακια
    /// π.χ αν ο χρηστης εισαγε 5 η εξοδος θα ειναι
    ///    *
    ///   ***
    ///  *****
    /// *******
    ///*********
    ///
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // για καθε νεα γραμμη εχουμε μειον 1 κενο και +2 αστερακια
            Console.WriteLine("enter heigth of pyramid");
            int height = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= height; i++)
            {
                for (int j =1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                for(int k = 1; k<= 2 * i -1; k++)
                {
                    Console.Write("*");

                }

                Console.WriteLine();
            }

        }
    }
}
