using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the PrimeChecker 2.0");
            Console.ReadKey();
            Console.Write("\nnumber/digit : ");
            string numberOrCiphers = Console.ReadLine();



            if (numberOrCiphers == "number")
            {
                Console.Write("Enter a number : ");

                string input = Console.ReadLine();

                BigInteger userInput = new BigInteger(input, 10);

                Stopwatch timer;
                timer = new Stopwatch();
                timer.Start();

                var isPrime = PrimeCheck(userInput);

                Console.WriteLine("Is prime : " + isPrime);

                timer.Stop();
                double timeInSeconds = timer.Elapsed.TotalSeconds;

                Console.WriteLine("It took " + timeInSeconds + " seconds");
                timer = new Stopwatch();
                timer.Start();

                PrimeCheck(userInput);

                timer.Stop();
                timeInSeconds = timer.Elapsed.TotalSeconds;

                Console.WriteLine("It took " + timeInSeconds + " seconds");
            }

            else if (numberOrCiphers == "digit")
            {
                Console.Write("Enter the amount of numbers : ");
                int amountOfNumbers = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter an amount of digits : ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                Stopwatch timer;
                timer = new Stopwatch();
                timer.Start();

                for (int index = 0; index < amountOfNumbers; index++)
                {
                    BigInteger randomNumber = FindRandomNumber(userInput);
                    Console.WriteLine("The random number is : " + randomNumber);

                    PrimeCheck(randomNumber);
                }

                timer.Stop();
                double timeInSeconds = timer.Elapsed.TotalSeconds;

                Console.WriteLine("It took " + timeInSeconds + " seconds");
            }


            else
                Console.WriteLine("This was not an option");


            Console.ReadKey();
        }






        static BigInteger FindRandomNumber(int userInput)
        {
            userInput = System.Math.Max(1, userInput);
            int[] randomNumbers = new int[userInput];

            Random random = new Random();

            int index = 0;
            randomNumbers[index] = random.Next(1, 10);
            index++;

            while (index < userInput - 1)
            {
                randomNumbers[index] = random.Next(0, 10);
                index++;
            }


            //Making the last digit odd
            if (index < userInput)
            {
                randomNumbers[index] = random.Next(0, 5) * 2 + 1;
            }


            //Convert the array into a long and return it.
            //I need to multiply the number with 10 to the power of its position in the array.
            BigInteger randomNumber = 0;
           
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumber += randomNumbers[i] * Convert.ToInt64 (Math.Pow(10, randomNumbers.Length - i - 1));
            }

            return randomNumber;
        }




        static bool PrimeCheck(BigInteger randomNumber)
        {
            if (randomNumber < 2)
                return false;
            if (randomNumber == 2)
                return true;
            

            
            BigInteger sqrtUserInput = randomNumber.sqrt();
            int index = 2;

            if (randomNumber % 2 == 0)
            {
                //Console.WriteLine("The number is even, it is divisible with " + index + "\n");
                return false;
            }

            index++;

            while (index < sqrtUserInput)
            {
                if (randomNumber % index == 0)
                {
                    //Console.WriteLine("This number is divisible with " + index + "\n");
                    return false;
                }
                index += 2;
            }

            //Console.WriteLine("This is a prime number!" + "\n");
            return true;

        }





        //Thierry
        private static readonly List<long> PrimesUpTo30 = new List<long> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

        public static bool IsPrime(long n)
        {
            if (n < 2) return false;
            foreach (var p in PrimesUpTo30)
            {
                if (n == p) return true;
                if (n % p == 0) return false;
            }

            var nsq = (long)System.Math.Sqrt(n) + 1;
            for (long i = 30; i < nsq; i += 30)
            {
                if (n % (i + 1) == 0)
                    return false;
                if (n % (i + 7) == 0)
                    return false;
                if (n % (i + 11) == 0)
                    return false;
                if (n % (i + 13) == 0)
                    return false;
                if (n % (i + 17) == 0)
                    return false;
                if (n % (i + 19) == 0)
                    return false;
                if (n % (i + 23) == 0)
                    return false;
                if (n % (i + 29) == 0)
                    return false;
            }

            return true;
        }

    }
}
