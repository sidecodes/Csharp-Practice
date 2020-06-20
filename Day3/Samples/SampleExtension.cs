using System;

namespace SampleExtension
{
    //This needs to be used, or the extension is not available!
    using ExtNs;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sample Extensions !");

            int i = 5;
            //We can use extension methods as if they are designed for the object
            i.Dump();

            //We now extend EVERY object in C#, since we applied the extension method
            //for this object
            "Hi there, how are you?".Dump();

            (5.0 - 3 * 2).Dump();

            //It is important to see, that extention methods are still just static methods
            //defined in some class. Hence the following way is also possible, however,
            //We see that this is a.) not as short as the other way and b.) from an 
            //object-oriented perspective not every meaningful
            MyExtensions.Dump("Another way"); 
        }
    }
}

//We need to use that namespace above!
namespace ExtNs
{
    //A class for our own extensions
    static class MyExtensions
    {
        //A dump method to output any object to the console
        public static void Dump(this object o)
        {
            Console.WriteLine("Extension method used!");
            Console.WriteLine(o);
        }
    }
}