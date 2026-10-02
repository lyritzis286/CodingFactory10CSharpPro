using System;
using System.Collections.Generic;
using System.Text;

namespace OOApp;
/// <summary>
/// Defines a product poco class
/// </summary>
internal class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is Product product &&
               Id == product.Id &&
               Name == product.Name &&
               Price == product.Price;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name, Price);
    }

    public override string? ToString()
    {
        return $"Product: {Id} {Name} {Price:C2}";
    }

}
