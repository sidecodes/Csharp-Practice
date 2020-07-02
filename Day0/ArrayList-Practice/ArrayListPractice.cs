using System;
using System.Collections;
namespace SampleArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates and initializes a new ArrayList
            ArrayList myAL = new ArrayList();

            Console.WriteLine("Adding some numbers:");
            myAL.Add(45);
            myAL.Add(78);
            myAL.Add(33);
            myAL.Add(9);
            // var a = myAL.Capacity;
            // var b = myAL.Count;
            Console.WriteLine("Capacity: {0} ", myAL.Capacity);
            Console.WriteLine("Count: {0}", myAL.Count);

            Console.Write("Values : ");
            foreach (int i in myAL) {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Values: ");
            myAL.Sort();
            foreach (int i in myAL) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
