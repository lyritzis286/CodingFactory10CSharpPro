namespace OOApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User alice = new User();
            User bob = new();
            var charlie = new User();
            Teacher TEACHER = new Teacher();
            Teacher teacher2 = new();
            var teacher3 = new Teacher();
            Teacher teacher4 = new Teacher(1, "John", "Doe");
            Teacher teacher5 = new() { Id = 2, Firstname = "Jane", Lastname = "Smith" };

            User dimis = new User //Object initializer syntax
            {
                Id = 1,
                Username = "dimis",
                Email = "",
                Password = ""
            };
        }
    }
}
