using System;
using System.Collections.Generic;
using System.Text;

namespace _3D_Objects_Calculator
{
    class Cone
    {
        public Cone(double radius, double height, double slant)
        {
            Radius = radius;
            Height = height;
            Slant = slant;
        }

        public double Radius { get; set; }
        public double Height { get; set; }
        public double Slant { get; set; }

        public double Area()
        {
            return Function.ConeArea(Radius, Slant);
        }

        public double Volume()
        {
            return Function.ConeVolume(Radius, Height);
        }
    }
}
