using System;

namespace Inheritance;

public class Reptile : Animal
{
    public string Hiss { get; set; }
    public string Movement { get; set; }
    public string Weaponry { get; set; }
    public string Length { get; set; }
    
    
    public void Tone()
    {
        Console.WriteLine($"Tone is now {Hiss}!");
    }

    public void Speed()
    {
        Console.WriteLine($"Probably best not to test this critters {Movement} reaction speed.");
    }

    public void Venom()
    {
        Console.WriteLine($"Lethal weaponry {Weaponry}is deadly.");
    }

    public void Size()
    {
        Console.WriteLine($"Shortened attack routine due to {Length} is too long.");
    }
}