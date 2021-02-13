using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace _3D_Objects_Calculator
{
   
    class Cylinder
    {
        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public double Radius { get; set; }
        public double Height { get; set; }



        public double Area()
        {
            return Function.CylinderArea(Radius,Height);
        }

        public double Volume()
        {
            return Function.CylinderVolume(Radius,Height);
        }
    }
}
