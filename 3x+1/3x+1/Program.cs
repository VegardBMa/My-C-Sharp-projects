using System;

namespace _3x_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeXplusOne();    
            Console.ReadKey();
        }
    
        static long ThreeXplusOne()
        {
            Console.Write("Enter a whole number : ");
            long num = Convert.ToInt64(Console.ReadLine());

            for(long index = 1; num > 1; index++)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                    Console.WriteLine(index + " : " + num);
                }

                else
                {
                    num = 3 * num + 1 ;
                    Console.WriteLine(index + " : " + num);
                }
                
            }

            return num;
        }
    
    
    }
}
