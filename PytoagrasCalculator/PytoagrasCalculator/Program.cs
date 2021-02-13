using System;
using System.Threading.Tasks.Dataflow;
using System.Transactions;

namespace PytoagrasCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a should always be the shortest side, return unknown with 0 \nCases : normal, 30 60 90,");
            Console.WriteLine("Enter you case : ");

            if (Console.ReadLine() == "normal")
                NormalCase();
            else if (Console.ReadLine().Contains("30"))
            {

            }

        }

        static double NormalCase()
        {
            Console.WriteLine("Enter a : ");
            double a = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter b : ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a > 0 && b > 0)
            {
                double answer = Math.Sqrt(Math.Pow(a , 2)  +  Math.Pow(b , 2));
                return answer;
            }

            else
            {
                Console.WriteLine("Enter c : ");
                double c = Convert.ToDouble(Console.ReadLine());

                if(a * 1 > 0)
                {
                    double answer = Math.Sqrt(Math.Pow(c , 2) - Math.Pow(a , 2));
                    return answer;
                }

                else
                {
                    double answer = Math.Sqrt(Math.Pow(c , 2) - Math.Pow(b , 2));
                    return answer;
                }

                
            }

        }


         double[] SquareThree()
        {
            Console.WriteLine("Enter a : ");
            double a = Convert.ToDouble(Console.ReadLine());

            if (a * 1 > 0)
            {
                double[] aIsKnown = new double[2];
                aIsKnown[0] = a;
                aIsKnown[1] = a * Math.Sqrt(3);
                aIsKnown[2] = a * 2;

                return aIsKnown;            
            }

            Console.WriteLine("Enter b : ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (b * 1 > 0)
            {
                
                double[] bIsKnown = new double[2];
                bIsKnown[0] = b / Math.Sqrt(3); ;
                bIsKnown[1] = b;
                bIsKnown[2] = bIsKnown[1] * 2;

                return bIsKnown;
            }


            else
            {
                Console.WriteLine("Enter c : ");
                double c = Convert.ToDouble(Console.ReadLine());

                double[] cIsKnown = new double[2];
                cIsKnown[0] = c / 2;;
                cIsKnown[1] = a * Math.Sqrt(3); ;
                cIsKnown[2] = c;

                return cIsKnown;
            }

         }






}
}
