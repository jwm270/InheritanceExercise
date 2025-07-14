using System;
using System.Globalization;

namespace Inheritance;

public class Animal
{
    public string Type { get; set; }
    public string Color { get; set; }
    public string Anger { get; set; }
    public string Diet { get; set; }

    public void Critter()
    {
        Console.Write($"Type of Critter is {Type}");
    }

    public void Camo()
    {
        Console.Write($"Type of Camo is {Color}. ");
    }

    public void Disposition()
    {
        Console.Write($"Type of Disposition is {Anger}. ");
    }

    public void Food()
    {
        Console.WriteLine($"Type of Food is {Diet}.");
    }
}