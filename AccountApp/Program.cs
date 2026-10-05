using AccountApp.Model;
using System.Xml;
namespace AccountApp;

internal class Program
{
    static void Main(string[] args)
    {
        var account = new Account()
        {
            Id = 1,
            Iban = "DE89370400440532013000",
            Firstname = "John",
            Lastname = "Doe",
            Ssn = "123-45-6789",
            Balance = 1000.00M

        };

        try
        {
            account.Deposit(50m);
            Console.WriteLine($"Deposit OK. New balance: {account.Balance}");
        }
        catch
        {

        }
    }
}
