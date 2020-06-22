using System;

namespace Task14
{
    /*

    14. Let's create a copy

    Extend the class Car of assignment 13 with a copy-constructor, i.e. a constructor which takes an instance of the own class as input parameter, and uses this instance to create a (usually deep) copy of all fields.

    Also override the method Equals() in a way that it is possible to compare one instance of the class Car with another for equality.

    Finally try to cast an instance of your Car class to the Porsche class. Why is this not possible?

    Ans:  /*
            
            Cannot implicitly convert type 'Task14.Car' to 'Task14.Porsche'. 
            An explicit conversion exists (are you missing a cast?) [Task14]
            
            //Porsche porscheIstance1Car = new Car();

            //var porsche = new Porsche();

            //Porsche porscheInstance2Car = porsche as Car;

            */

    */

    //Abstract class
    abstract class Vehicle 
    {
        //protected variable
        protected int tires;

        //Standard constructor
        public Vehicle()
        {

        }

        //Copy constructor
        // C# doesn't provide a copy constructor for objects, but you can write one yourself.
        // Read More from documentation ... :)
        public Vehicle(Vehicle vehicle)
        {
            this.tires = vehicle.tires;
        }

        //Get-Property for the variables
        public int Tire
        {
            get { return tires; }
        }

        //Some abstract methods
        public abstract void Accelerate();

        public abstract void Brake();

        //... and a virtual one!

        public virtual void Drive()
        {
            Console.WriteLine("Driving the vehicle!");
        }
    }
}