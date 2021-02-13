using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace _3D_Objects_Calculator
{
    public class Sphere
    {
        public Sphere(double radius)
        {
            Radius = radius;
        }
   
        public double Radius { get; set; }

        public double Area()
        {
            return Function.SphereArea(Radius);
        }

        public double Volume()
        {
            return Function.SphereVolume(Radius);
        }
    }
}
