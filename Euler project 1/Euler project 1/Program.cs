﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler_project_1
{
    class Program
    {



        static void Main(string[] args)
        {
            //Console.WriteLine(Euler1());
            //Console.WriteLine("The highest value following the rules is : " + Euler2());
            //Console.WriteLine("The biggest prime factor is " + Euler3());
            //Console.WriteLine(Euler4());
            Console.WriteLine(Euler5());
            Console.ReadKey();
        }


        static bool PrimeCheck(int userInput)
        {
            
            
            if (userInput % 2 == 0)
            {
                return false;
            }

            bool isPrime = true;

            for (int index = 3; index * index < userInput; index++)
            {
                if (userInput % index == 0)
                {               
                    isPrime = false;
                }
            }

            return isPrime;
        }


        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        //Find the sum of all the multiples of 3 or 5 below 1000.
        static int Euler1()
        {
            int sum = 0;

            for (int index = 1; index < 1000; index++)
            {

                if ((index % 3 == 0) || (index % 5 == 0))
                {
                   
                     sum += index;
                    
                }

            }
            return sum;
        }


        //Each new term in the Fibonacci sequence is generated by adding the previous two terms.By starting with 1 and 2, the first 10 terms will be:
        //1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        static long Euler2()
        {

            long limit = 4000000;         
            long previousNum = 1;
            long currentNum = 1;
            long buffer;
            long answer = -1;

            while (limit > currentNum)
            {
                Console.WriteLine(previousNum);
                buffer = currentNum + previousNum;

                
                if (limit > buffer)
                {
                    previousNum = currentNum;
                    currentNum = buffer;
                    answer = currentNum;
                }
                else
                {
                    break;
                }
                
            }
            return answer;


           
        }

        //The prime factors of 13195 are 5, 7, 13 and 29.
        //What is the largest prime factor of the number 600851475143 ?
        static int Euler3()
        {
            long bigNumber = 600851475143;
            double sqrtBigNumber = Math.Round(Math.Sqrt(bigNumber));
            int factor;
            double sqrtFactor;
            int primeFactor = 0;

            
            for (int index = 3; index < sqrtBigNumber; index += 2)
            {
                if(bigNumber % index == 0)
                {
                    factor = index;
                    sqrtFactor = Math.Round(Math.Sqrt(factor));
                    

                    for (int FactorIndex = 2; FactorIndex < sqrtFactor; FactorIndex++)
                    {
                        if (PrimeCheck(factor) == true)
                        {
                            primeFactor = factor;
                            Console.WriteLine(primeFactor);
                            break;
                        }
                    }
                }
            }

            return primeFactor;
        }
        static int Euler4()
        {
            int factor1 = 100;
            int factor2 = 100;
            int sum = factor1 * factor2;
           




            return sum;
        }

        static int Euler5()
        {
            //bool isDivisible = true;
            int answer = -1;
            int amountOfDivisibles = 0;
            
            bool isDivisible = true;
            

            for(int index = 20; index < 10000|; index++)
            {
                for(int i = 1; i < 21; i++)
                {
                    if(index % i > 0)
                    {
                        isDivisible = false;
                    }
                    else if(isDivisible == true && amountOfDivisibles > 19)
                    {
                        answer = index;
                        return answer;
                    }
                    else if(isDivisible == true)
                    {
                        amountOfDivisibles++;
                    }
                }

                
         
            }

            return answer;
        }






    }
}
