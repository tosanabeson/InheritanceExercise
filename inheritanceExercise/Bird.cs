using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanceExercise
{
    public class Bird : Animal 
    {
        public Bird ()
        {
            IsAlive = true;
            LegCount = 2;
            LandSeaAir = "Air";
            Age = 0;

        }
        public string wingColor { get; set; }
        public bool CanFly { get; set; }
        public bool WillMigrate { get; set; }
        public double BeakLength { get; set; }

    }
}
