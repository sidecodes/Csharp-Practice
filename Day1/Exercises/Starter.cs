using System;
namespace Task01
{
    /*
    1. Let's get started

    Let's display some messages on the console and request the user to enter his name.
    Output a friendly welcome message with the user's name.

    Run this application with the debugger and without the debugger.
    Can you see any differences? Try setting a breakpoint and play around with the debugger.
    
    */

    internal class Starter
    {
        //static method to call it like Starter.DisplayUser()
        public static void DisplayUser()
        {
            //Write some info on the console
            Console.WriteLine("Please enter your name:");
            //Request the user to input his name, store it in name
            string name = Console.ReadLine();
            //Output the name of the user by using a formatted string
            Console.WriteLine("Your name is {0}. Hi!", name);
        }
    }
}