using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsAlive = true;
            Longevity = 40;
            Habitat = "desert";
            LegCount = 4;

        }
        public bool CanGrowTail { get; set; }
        public bool SouthOfEquator { get; set; }
        public int TailLength { get; set; }
        public double TongueLength { get; set; }


    }
}
