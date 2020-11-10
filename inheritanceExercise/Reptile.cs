using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanceExercise
{
    public class Reptile : Animal
    {
        public Reptile()
        {

        }
        public bool IsColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public string Habitat { get; set; }
        public bool CanGrowTail { get; set; }

    }
}
