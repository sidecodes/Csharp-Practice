using System;

namespace FullExampleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a nice guy
            NiceGuy m = new NiceGuy();
            //Create a bad guy
            BadGuy b = new BadGuy(3);

            //Let each of them use their own implementation of the Hero-warcry
            m.warCry();
            b.warCry();

            //set the strength with a property
            m.Strength = 4;
            //test the fallback
            m.Strength = -10;

            //the old fashioned way of doing properties in e.g. C++
            m.setStrength(4);

            //cast the niceguy to its interface
            ((IHaveAwesomeWeapon)m).useThisAwesomeWeapon();
        }
    }

    //abstract class Hero
    abstract class Hero
    {
        int HP;
        public readonly string name; //can only be set in the constructor of this class

        //not so good. Start with it but change it to the lower case (Strength) as soon as needed.
        public int X { get; set; }

        //field for the property
        int strength;

        //property
        public int Strength
        {
            get //to get the value int s = this.Strength
            {
                return strength;
            }
            set //to set the value this.Strength = 5;
            {
                if (value > 0) //a boundary condition to be fulfilled before setting the value
                    strength = value;
                else //fallback
                    Console.WriteLine("Nope, no values smaller 0 allowed");
            }
        }

        //only for demo how it was done in languages without properties
        public void setStrength(int value)
        {
            strength = value;
        }

        //constructor 1
        public Hero(int HP)
        {
            this.HP = HP;
            this.Strength = 5;
        }
        //constructor 2
        public Hero(string s)
        {
            this.name = s;
        }

        //constructor 3
        public Hero(int HP, string n)
        {
            this.HP = HP;
            name = n;
        }
        //attack method which can already be used in child-classes
        public virtual void attack(Hero b)
        {
            Console.WriteLine(this.name + "attacks" + b.name);
        }
        //abstarct method which HAS TO BE implemented in child class
        public abstarct void warCry();

        //some other method
        public virtual void savePrincess()
        {
            Console.WriteLine(this.name + "saves the princess.");
        }
    }

    //Nice guy, inherits from Hero and interface IHaveAwesomeWeapon
    class NiceGuy : Hero, IHaveAwesomeWeapon
    {
        //additionally to usual behaviour he can jump
        bool jumping;

        //constructir 1 - calling base constructor 3
        public NiceGuy(int hp, bool jmp) : base(hp, "NiceGuy")
        {
            jumping = jmp;
        }
        //default/empty constructor - calling base constructor 3
        public NiceGuy() : this(3, true)
        {

        }

        //additional jump method
        public void jump()
        {
            Console.WriteLine("NiceGuy is jumping");
        }

        //implementation of the Hero warcry
        public override void warCry()
        {
            Console.WriteLine("NiceGuy!");
        }
        //implementation of the interface
        public void useThisAwesomeWeapon()
        {
            Console.WriteLine("Aweseome booster in use");
        }

        //test function - look at BabyNiceGuy and remove the virtual keyword
        public virtual void test()
        {
            ;
        }
    }

    //Badguy - nevertheless a hero
    class BadGuy : Hero
    {
        //no default constructor provided - only this one

        public BadGuy(int HP) : base(HP, "BadGuy")
        {

        }
        //has another attack method which is NEW.
        //it doesnot override the hero method, which means we can also use this one
        //when casting badguy to hero
        public new void attack(Hero b)
        {
            base.attack(b);
            Console.WriteLine("Muhahahahah this was BadGuy");
        }

        //implementation of the warcry
        public override void warCry()
        {
            Console.WriteLine("BadGuy!");
        }
    }

    //just to prove the point that the virtual keyword is needed to override a function
    class BabyNiceGuy : NiceGuy
    {
        public BabyNiceGuy() : base(1, true)
        {

        }
        public override void test()
        {
            base.test();
        }
    }

    //a demo of an interface
    internal interface IHaveAwesomeWeapon
    {
        void useThisAwesomeWeapon();
    }
}