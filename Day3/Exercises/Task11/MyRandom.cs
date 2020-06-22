using System;

namespace Task11
{
    /*

    11. Extending existing classes

    Create a class called MyRandom, which derives from the .NET class Random, 
    but returns different values. 
    Implement a new method called Next() and 
    a possibility to access the protected method Sample() from outside.    

    */

    internal class MyRandom : Random
    {
        //Store another field for some arbitrary value
        int value = 2;

        public override int Next()
        {
            //This not so random any more (certainly different!)
            return value++; // ++value -> prefix // value++ -> postfix
        }

        public double MySample()
        {
            //Now we return the result of a call to Sample(), which is usually hidden
            return Sample();
        }
    }
    
}