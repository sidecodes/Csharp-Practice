using System;

namespace Task12
{
    //The structure
    struct Point3
    {
        //Its fields
        float x;
        float y;
        float z;

        //Another constructor (takes the above defined fields)
        public Point3 (float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z =z;
        }

        //For the X field
        public float X
        {
            get { return x; }
            set
            {
                //Change in it!!
                Console.WriteLine("X changed from {0} to {1}.", x, value);
                x = value;
            }
        }

        public float Y
        {
            get { return y; }
            set
            {
                Console.WriteLine("Y changed from {0} to {1}.", y, value);
                y = value;
            }
        }

        public float Z
        {
            get { return z; }
            set
            {
                Console.WriteLine("Z changed from {0} to {1}.", z, value);
                z = value;
            }
        }

        //This is how operator overloading looks like
        /*

        A user defined type can overload a predefined C# operator.
        That is, a type can be provided the custom implementation of an operation in case one 
        or both of the operands are of that type.

        Use the operator keyword to declare an operator.
        An operator declaration must satisfy the following rules:

        1.  It includes both a public and a static modifier.

        2.  A unary operator has one input parameter.
            A binary operator has one input parameter.
            In each case, at least one parameter must have type T or T?
            where T is the type that contains the operator declaration.

        Read More ... :)

        */

        public static Point3 operator +(Point3 a, Point3 b)
        {
            //Just return a new one
            return new Point3(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Point3 operator -(Point3 a, Point3 b)
        {
            return new Point3(a.x - b.x, a.y - b.y, a.z - b.z);
        }
    }
}