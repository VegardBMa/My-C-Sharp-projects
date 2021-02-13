using System;

namespace Luke_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int inhabitants = 5433000;
            int presentsDelivered = 0;
            //int throwPresents = 0;
            int closestPrime = 0;

            for (int index = 0; index < inhabitants + 1;)
            {
                if (index.ToString().Contains("7"))
                {
                    bool continueForwards = false;

                    for (int i = 0; continueForwards == false; i++)
                    {
                        int checkClosestHigherPrime = index + i;
                        int checkClosestLowerPrime = index - i;

                        if (PrimeCheck(checkClosestHigherPrime))
                        {
                            closestPrime = checkClosestHigherPrime;
                            continueForwards = true;
                        }

                        if (PrimeCheck(checkClosestLowerPrime))
                        {
                            closestPrime = checkClosestLowerPrime;
                            continueForwards = true;
                        }
                    }
                    index += closestPrime;
                    index++;
                }

                else
                {
                    Console.WriteLine(index);
                    presentsDelivered++;
                    index++;
                }
            }

            Console.WriteLine($"There were {presentsDelivered} presents delivered.");
            Console.ReadKey();
        }

        private static bool PrimeCheck(int checkClosestPrime)
        {
            bool isPrime = true;
            if (checkClosestPrime % 2 == 0)
            {
                return false;
            }
            for (int index = 3; index < Math.Sqrt(checkClosestPrime); index += 2)
            {
                if (checkClosestPrime % index == 0)
                {
                    return false;
                }
            }

            if (isPrime == true)
            {

            }

            return isPrime;
        }
    }
}
