using System;

namespace Task06
{
    /*

    6. Write a swap method

    Write a simple method called Swap() to exchange to given integers. 
    The method should work in such a way, that the following program works:

    int a = 0;
    int b = 1;
    //Calling Swap with a and b

    if (a != 1 || b!= 0)
	        throw new Exception("Swap does not work yet!");

    Console.WriteLine("Swap seems to work for this case!");
    
    */

    internal class MySwap
    {
        //A simple test for our swap method
        public static void TestSwap()
        {
            //Some initial values
            int a = 0;
            int b = 1;
            //Call the swap method
            Swap(ref a, ref b);

            //If the values haven't been swapped, throw this exception
            if (a != 1 || b != 0)
                throw new Exception("Does not work!!");

            //Alright!
            Console.WriteLine("Works!");
        }

        //This is the swap method
        public static void Swap(ref int a, ref int b)
        {
            //Swap by using a temporary variable
            int tmp = a;
            a = b;
            b = temp;
        }

        /*
            //Swap without using a temporary variable
            //example - 7 and 5 
            a = 7 + 5
            b = 12 - 5
            a = 12 - 7 

            //Code
            a = a + b;
            b = a - b;
            a = a - b;
        */
    }
}