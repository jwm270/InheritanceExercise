using System;

namespace Inheritance;

public class Bird : Animal
{
    public string Sound { get; set; }
    public string Speed { get; set; }
    public string Ammo { get; set; }
    public string LifeSpan { get; set; }

    public void Song()
    {
        Console.WriteLine($"Tweet, tweet yo bad self {Sound}!!!");
    }

    public void Velocity()
    {
        Console.WriteLine($"Flight airspeed is not comparable to the African Swallow at {Speed}, so no grail hunting.");
    }

    public void Stool()
    {
        Console.WriteLine($"Non-lethal weaponry {Ammo} is very stinky and sticky.");
    }

    public void Termination()
    {
        Console.WriteLine($"Shortened routine due to {LifeSpan} is too low.");
    }
}