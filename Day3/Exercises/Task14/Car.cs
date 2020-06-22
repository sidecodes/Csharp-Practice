using System;

namespace Task14
{
    //Deriving from vehicle
    internal class Car : Vehicle
    {
        //Automatic property
        public int Gears
        {
            get;
            set;
        }

        //Standard constructor
        public Car()
        {
            //Set the value of tires to 4
            tires = 4;
        }

        //Copy constructor
        // C# doesn't provide a copy constructor for objects, but you can write one yourself.
        public Car(Car car)
            : base(car)
        {
            this.Gears = car.Gears;
        }

        //Equals(Object)
        //Determines if the underlying system type of the current Type object is the same as
        //the underlying system type of the specified Object.
        public override bool Equals(object obj)
        {
            if (obj is Car)
            {
                var other = (Car)obj;
                return other.tires == this.tires && other.Gears == this.Gears;
            }

            return false;
        }

        public override void Accelerate()
        {
            Console.WriteLine("The car is accelerating");
        }

        public override void Brake()
        {
            Console.WriteLine("The car is braking");
        }
    }
}