using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Bird b1 = new Bird();
            b1.CanFly = true;
            b1.BeakLength = 10.55;
            //beak length in centimeters
            b1.Migrates = true;
            b1.WingColor = "blue";


            Reptile r1 = new Reptile();
            r1.CanGrowTail = true;
            r1.SouthOfEquator = true;
            r1.TailLength = 6;           
            r1.TongueLength = 5.2;
            //tongue length in centimeters && tail length in inches

            // Creatively display the class member values


            var animals = new Animal[] { b1, r1 };

            foreach (var animal in animals)
            {
                Console.WriteLine($"Alive: {animal.IsAlive}");
                Console.WriteLine($"Longevity in years: {animal.Longevity}");
                Console.WriteLine($"Natural Habitat: {animal.Habitat}");
                Console.WriteLine($"Leg Count: {animal.LegCount} legs");


            }
      
        }
    }
}
