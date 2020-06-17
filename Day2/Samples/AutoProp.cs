using System;
using System.Collections.Generic;


namespace AutoProp
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class MyClass
    {
        //Usually it is enough to create a variable and use VS
        //to create the property
        int myVariable;

        //Or we just write it out - this is the "long way"
        public int MyVariable
        {
            get { return myVariable; }
            set { myVariable = value; }
        }

        //Now we use the auto-generate property
        //we need both: the get and the set
        public int myVariableAuto
        {
            get;
            set;
        }

        //However, we can restrict the access to a part
        //(like the set here) to another modifier (like private)
        public int myVariableAutoOnlyGet
        {
            get;
            private set;
        }

        //AutoImplemented using VS
        //This uses Annonymous methods using lambda expressions (More Further)
        public int MyVariable1 { get => myVariable; set => myVariable = value; }
    }
}