//Now we are only using the system namespace - we do not need more
using system;

class Program
{
    static void Main(string[] args)
    {
        //Creating an array is possible by just appending [] to any datatype
        int[] myints = new int[4];
        //This is now a fixed array with 4 elements. Arrays in c# are 0-based
        //hence the first element has index 0.
        myints[0] = 2;
        myints[1] = 3;
        myints[2] = 17;
        myints[3] = 24;

        //Also any array type instance, i.e. an instance of any type that appends
        //the brackets [] has the property Length.
        Console.WriteLine("Length = " + myints.Length);

        //This foreach construct is new in C#. (Compared to C++)
        foreach(int myint in myints)
        {
            //Write will not start a new line after the string.
            Console.Write("The element is given by ");
            //WriteLine will start a new line after performing the operation.
            Console.WriteLine(myint);
        }
    }
}