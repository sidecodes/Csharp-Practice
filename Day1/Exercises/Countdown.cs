using System;
using System.Threading;

namespace Task02
{
    /*
    2. The first countdown
    
    Use a for loop to create a countdown from 10 to 1.
    Each number should be displayed after a waiting time of 1 second.
    Realize that waiting period by using Thread.Sleep(1000) of the System.Threading namespace.

    */
    internal class Countdown
    {
        //static method for calling it like Countdown.Run()

        public static void Run()
        {
            //The for loop going 10, 9, ..., 1
            for (int i = 10; i > 0; i--)
            {
                //Output the time that is left
                Console.WriteLine("Still {0} seconds left ...", i);
                //Wait a second before starting the next iteration
                Thread.Sleep(1000);
            }
        }
    }
}