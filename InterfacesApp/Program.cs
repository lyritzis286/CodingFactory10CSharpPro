namespace InterfacesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1  = new()
            {X = 1};

            p1.Move10();
            p1.Move5();
        }
    }
}
