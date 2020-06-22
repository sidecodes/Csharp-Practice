using system;

namespace Task13
{
    /*

    13. Vehicle, Car, ...

    Start by creating an abstract class called Vehicle. 
    Create two abstract methods called Accelerate() and Brake(). 
    Additionally you should place an (protected) integer variable called tires. 
    Add a property called Tire, which defines a get block for the variable.

    Derive a class called Car from Vehicle. 
    Implement the two functions in such a way, that they display the state change like "The car is is accelerating" or "The car is braking" on the console. 
    Additionally extend the class with an integer property called Gears (with get and set) and set the value of tires to 4.

    Finally derive from Car and call the new class Porsche. 
    Override the method Accelerate() with some string that might represent your attitude towards driving a Porsche.

    */

    //Abstract class
    abstract class Vehicle
    {
        //protected variables
        protected int tires;

        //Get-Property for the variable
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