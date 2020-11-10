using inheritanceExercise;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            myBird.wingColor = "Blue";
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.BeakLength = 3.5;

            var lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "Swamp",
                CanGrowTail = true
            };

            var myAnimals = new Animal[] { myBird, lizard };
            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age} years old");
                Console.WriteLine($"It has {animal.LegCount}  legs");
                Console.WriteLine($"It lives by{animal.LandSeaAir}");
                Console.WriteLine($"");

            }





            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}