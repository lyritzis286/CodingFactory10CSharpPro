using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractApp;

internal class Cat : AbstractAnimal
{
    public override string ToString()
    {
        return $"Cat: {Id} {Name} {Age}";
    }
    public override void Eat()
    {
        Console.WriteLine($"{Name} is eating cat food.");
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}
