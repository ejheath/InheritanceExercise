using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            IsAlive = true;
            Longevity = 75;
            Habitat = "rainforest";
            LegCount = 2;
        }
        public bool CanFly { get; set; }
        public double BeakLength { get; set; }
        public bool Migrates { get; set; }
        public string WingColor { get; set; }
    }
}
