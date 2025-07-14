using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var finch = new Bird();
            finch.Type = "military weapon...";
            finch.Color = "yeller";
            finch.Anger = "not angry";
            finch.Diet = "worms and stuff";
            finch.Sound = "Ka-KAWWWW";
            finch.Speed = "20 MPH";
            finch.Ammo = "stank poop";
            finch.LifeSpan = "5 years of age";

            var racer = new Reptile() 
            { 
                Type = "civilian political strategist. ", 
                Color = "shady", 
                Anger = "always", 
                Diet = "constituents",
                Length = "99 freaking inches", 
                Hiss = "LOUD AND ANNOYING!", 
                Movement = "55 mph", 
                Weaponry = "of FANGS " 
            };
            
            var zoo = new List<Animal>() {finch, racer};

            foreach (var animal in zoo)
            {
                Console.WriteLine($"Type: {animal.Type}\nColor: {animal.Color}\nAnger: {animal.Anger}\nDiet: {animal.Diet}\n");
            }
            
            finch.Critter();
            finch.Song();
            finch.Camo();
            finch.Disposition();
            finch.Food();
            finch.Velocity();
            finch.Stool();
            finch.Termination();
            
            racer.Critter();
            racer.Tone();
            racer.Speed();
            racer.Venom();
            racer.Size();
        }
        

        // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *
             * Creatively display the class member values
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
    }
}
