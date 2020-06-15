using System;
using System.Collections.Generic;

namespace Task05
{
    /*
    5. Computing prime numbers

    The user has to enter some number, which should be evaluated by your program.
    If the program detects a non-positive, or invalid number, the program should exit.
    Otherwise the evaluation should display if the entered number has been a prime number or not.
    In case of not being a prime number, the program has to display all the prime factors of the given number.
    
    */
    internal class PrimeNumbers
    {
        //This method can be accessed like PrimeNumbers.Computer()
        public static void Computer()
        {
            //Some output
            Console.WriteLine("Please enter a positive integer number:");
            //The UInt32 value type represents unsigned integers with
            //values ranging from 0 to 4,294,967,295
            uint value;

            //Evaluate the given value using TryParse() and 
            //using out will enforce assignment of the variable 'value'.
            if (!uint.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("The provided input is not a positive integer number.");
                return;
            }

            //Compute the prime factors
            
            //Generic Type (way of reusing code)
            //Represents a strongly typed function
            List<uint> factors = ComputeFactorsOf(value);

            if (factors.Count == 1)
            {
                //If there is just one we have a prime number
                Console.WriteLine("This is a prime number!");
            }
            else
            {
                //Otherwise we have no prime number .. 
                //so we print the prime factors
                
                //string.Join() - Concatenates the elements of a specified array or the members of a collection
                //using the specified separator between each element or member.

                Console.WriteLine("The value has the prime factors {0}.", string.Join(", ", factors));
            }

        }

        //Create a helper function for computing the various prime factors
        //Generic Type - Strongly Typed function body
        static List<uint> ComputeFactorsOf(uint number)
        {
            //Remember the various factors
            //Strongly Typed list of objects that can be accessd by index.
            //Also provides methods to search, sort, and manipulate lists.
            List<uint> factors = new List<uint>();
            
            
            uint factor = 2;

            //As long as the number can be divided by something
            while (number > 1)
            {
                //Can it be divided by the factor
                uint rest = number % factor;

                if (rest == 0)
                {
                    //Breaking the Number into a Prime factor
                    number /= factor;
                    //Adding the factor
                    factors.Add(factor);
                }
                else
                    factor++;
            }

            return factors;

        }
    }
}