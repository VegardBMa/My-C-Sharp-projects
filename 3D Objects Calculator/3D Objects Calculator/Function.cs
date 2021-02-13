using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace _3D_Objects_Calculator
{
    public static class Function
    {
        //Sphere
        public static double SphereVolume(double radius)
        {
            return 4.0 / 3.0 * PI * (Pow(radius, 3) );
        }

        public static double SphereArea(double radius)
        {
            return 4.0 * PI * (Pow(radius, 2));

        }


        //Cylinder
        public static double CylinderArea(double radius, double height)
        {
            return 2 * PI * radius * (height + radius);
        }

        public static double CylinderVolume(double radius, double height)
        {
            return PI * (Pow(radius, 2)) * height;
        }


        //Cone
        public static double ConeArea(double radius, double slant)
        {
            return PI * radius * slant + PI * Pow(radius, 2);
        }

        public static double ConeVolume(double radius, double height)
        {
            return 3 / PI * (Pow(radius, 2)) * height;
        }

    }
}
