using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool Scales { get; set; } 
        public bool Carnivore { get; set; } 
        public string ClawType { get; set; }
        public string SkinType { get; set; }
    }
}
