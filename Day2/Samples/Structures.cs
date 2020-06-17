using System;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usually c# forbids us to leave variables uninitialized
            SampleClass sampleClass;
            SampleStruct sampleStruct;

            //However, c# thinks that an out-function will do the initialization
            HaveALook(out sampleClass);
            HaveALook(out sampleStruct);
        }

        static void HaveALook(out SampleClass c)
        {
            //Insert a breakpoint here to see the
            //value of c before the assignment:
            //It will be null...
            c = new SampleClass();
        }

        static void HaveALook(out SampleStruct s)
        {
            //Insert a breakpoint here to see the
            //value of s before the assignment:
            //It will NOT be null...
            s = new SampleStruct();
        }

        //In c# you can create nested classes
        class SampleClass
        {

        }

        //A structure always inherits ONLY from object,
        //we cannot specify other classes (more on that later)
        //However, an arbitrary number of interfaces can
        //be implemented (more on that later as well)
        struct SampleStruct
        {
            
        }
    }
}