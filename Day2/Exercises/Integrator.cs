using System;

namespace Task08
{
    /*

    8. Simple numerical integration

    Approximate the integral of a function by taking the sum of the areas of rectangles, i.e. compute

    F=∫ab f(x)dx ≈ ΔxΣif(xi).

    Pack everything in a method called Integrate. This method should take 4 input parameters:

        A double, which represents the start of the integral a.
        A double, which represents the end of the integral b.
        An int, which represents the number of rectangles N.
        A Func<double, double>, which represents the function f.

    Use your method to show that the value of the integral is becoming more precise as N increases.

    */

    internal class Integrator
    {
        //Call it like Integrator.Integrate(0, 1, 1000, Math.Sin)
        //Math.Sin -> returns the sine value (Read more at - https://docs.microsoft.com/en-us/dotnet/api/system.math.sin?view=netcore-3.1)
        public static double Integrate(double a, double b, int N, Func<double, double> f)
        {
            //Compute Delta x by dividing the whole x range by the number of rectangles
            double width = (b - a) / N;
            //store the sum
            double sum = 0.0;
            //start at x = a;
            double x = a;

            for (int i = 0; i < N; i++)
            {
                //Add it to the global sum
                sum += f(x);
                //Increase x, i.e. x_i = x_[i-1]+Delta x
                x += width;
            }

            //In the end multiply with the Delta x
            return sum * width;
        }
    }
}