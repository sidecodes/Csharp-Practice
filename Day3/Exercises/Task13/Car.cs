using System;

namespace Task13
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

        public Car()
        {
            //Set the values of tires to 4
            tires = 4;
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