using System;

namespace Lambda
{
    //This looks like a function prototype except that the first keyword is delegate
    /*

    Delegates provide a late binding mechanism in .NET. 
    Late Binding means that you create an algorithm 
    where the caller also supplies at least one method that 
    implements part of the algorithm.
    Read More ...

    */
    delegate double MyDoubleDelegate(double x);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lambda!");

            //If we just use the method's name we get the reference
            //of the method. We need to save it in a delegate type
            //that fulfills the signature (return type and argument types)
            //of the method
            MyDoubleDelegate squareNormal1 = Square;

            //The generic delegate Func<Tin, Tout> gives us a
            //really general delegate that can easily be specified
            Func<double, double> squareNormal2 = Square;

            //Now we do the same with a lambda expression
            /*
            
            A lambda expression is an expression of any of the following two forms:
            
            Expression Lambda: Has an expression as its body.
            (input-parameters) => expression

            Statement Lambda: Has a statement block as its body.
            (input-parameters) => { <sequence-of-statements> }
            
            */
            Func<double, double> squareLambda = x => x * x;
            
            //Question: What is shorter?

            Console.WriteLine(squareLambda(2));

            //There are other generic types like Action for no return value
            Action<string> printf = str => Console.WriteLine(str);

            //The method behind a delegate can be accessed by using the delegate
            //instance like a method (just calling it with some arguments):
            printf("Hi there!");
            printf("how are you>!");

            //Another popular generic delegate is the predicate, which
            //always returns a boolean
            /*

            Represents the method that defines a set of criteria and 
            determines whether the specified object meets those criteria.
            public delegate bool Predicate<in T>(T obj);
            Read More ...

            */
            
            //Was unable to do Predicate with two arguments 
            //!!!
            int r = 10;
            Predicate<int> equal = (l) => l == r;
            l = 2;
            if(equal(l))
                printf("The number is equal");
            else
                printf("The number is not equal (how?!).")
                
            if(equal(10))
                printf("The number is equal :)");
        }

        static double Square(double x)
        {
            return x * x;
        }
    }
}