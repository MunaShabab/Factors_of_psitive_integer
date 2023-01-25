using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
//Exercise 73
//written by: Muna Shabab
//date:10-8-2020

namespace _73_Muna_Shabab
{
    class Program
    {
        static void Main(string[] args)
        {
            //explain the program to the user
            Console.WriteLine("This application takes in an integer greater than or equal to 3" +
                "and finds out its factors");

            //get the number from the user and validate
            Console.WriteLine("Enter an integer greater than or equal to 3:");
            string input = Console.ReadLine();
            int number = GetValidInteger(input);

            //find out the factors
            int[] foundFactors = PrimeCheck(number);

            //check if the number is a prime
            //if it is not
            if (foundFactors.Length >= 1 && foundFactors[0] != number)
            {
                if (foundFactors.Length == 1)
                {
                    Console.Write("the number " + number + " is not prime and its factor is "
                        + foundFactors[0]);
                }
                else
                {
                    Console.Write("the number " + number + " IS NOT Prime and its factors are "
                        + foundFactors[0]);

                    for (int i = 1; i < foundFactors.Length; i++)
                    {
                        Console.Write(" , " +foundFactors[i]  );
                    }
                }
                


            }
            //if the number is prime
            else 
            {
                Console.WriteLine("the number " +number + " IS Prime");
                
            }
            Console.ReadLine();

        }
        public static int GetValidInteger(string input)
        {
            int num;
            while ((!(int.TryParse(input, out num))) || num < 3)
            {

                Console.WriteLine(input + " is not a valid  input");
                Console.WriteLine("please enter a positive integer greater or equal to  3:");
                input = Console.ReadLine();
            }

            return num;
        }
        public static int[] PrimeCheck(int intToCheck)
        {
            int factor = 2;
            int numberOfFactors = 0;
            
            while (factor <= intToCheck)
            {
                
                if (intToCheck%factor==0)
                {
                    ++numberOfFactors;
                }

                ++factor;
                
            }
            int[] factorsArray = new int[numberOfFactors];

            //if the number is prime assing it to the array
            if (numberOfFactors==1)
            {
               
                factorsArray[0] = intToCheck;
            }
            //otherwise assign the factors to a new array  
            else
            {
                int[] notPrimeFactorArray = new int[numberOfFactors - 1];
                int counter = 0;
                for (int i = 2; i< intToCheck;i++)
                    {
                        
                        if(intToCheck%i==0)
                            {
                                notPrimeFactorArray[counter] = i;
                        
                                counter++;
                            }
                     }
                factorsArray = notPrimeFactorArray;
            }

            return factorsArray;
        }
    }
}
