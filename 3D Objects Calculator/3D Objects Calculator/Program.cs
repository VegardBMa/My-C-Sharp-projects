using System;
using static System.Math;
namespace _3D_Objects_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a geometrical object : ");
            string userInput = Console.ReadLine();

            if (userInput == "sphere")
            {
                Console.Write("Enter the radius : ");
                double userRadius = Convert.ToDouble(Console.ReadLine());

                Sphere sphere = new Sphere(userRadius);

                Console.WriteLine("The surface area of the sphere  = " + sphere.Area() + " units^2");
                Console.WriteLine("The volume of the sphere        = " + sphere.Volume() + " units^3");
            }

            else if (userInput == "cylinder")
            {
                Console.Write("Enter the radius : ");
                double userRadius = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the height : ");
                double userHeight = Convert.ToDouble(Console.ReadLine());

                Cylinder cylinder = new Cylinder(userRadius, userHeight);

                Console.WriteLine("The surface area of the cylinder  = " + cylinder.Area() + " units^2");
                Console.WriteLine("The volume of the cylinder        = " + cylinder.Volume() + " units^3");

            }

            else if (userInput == "cone")
            {
                Console.Write("Enter the radius : ");
                double userRadius = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the height : ");
                double userHeight = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the slant : ");
                double userSlant = Convert.ToDouble(Console.ReadLine());

                if (userSlant == 0)
                    userSlant = Sqrt(Pow(userHeight, 2) + Pow(userRadius, 2));

                else if (userHeight == 0)
                    userHeight = Sqrt(Pow(userSlant, 2) - Pow(userRadius, 2));

                Cone cone = new Cone(userRadius, userHeight, userSlant);

                Console.WriteLine($"The surface area of the cone  = " + cone.Area() + " units^2");
                Console.WriteLine("The volume of the cone         = " + cone.Volume() + " units^3");

            }

            else
            {
                Console.WriteLine("This was not an option.");
            }


            Console.ReadKey();

        }
    }
}
