using System;

namespace Task09
{
    /*

    9. Digit sum

    Create a method, which has an int argument (called number) and an out of int argument (called digits). 
    The return type should be an int as well.

    This method would then compute the digit sum of all digits in the given number argument. 
    The digits argument should be set to the number of given digits in number, 
    while the result of the computation would be returned.

    */

    internal class DigitSum
    {
        //Can be called by DigitSum.Compute(12345, out o)
        //Create an int o; in the Main class.
        public static int Compute(int number, out int digits)
        {
            string s = number.ToString();
            //assign the out parameter to the length of the string ( # of digits )
            digits = s.Length;
            int sum = 0;

            for (int i = 0; i < digits; i++)
            {
                //The integer for a char that represents "0" is
                //different from 0. Therefore we need to substract
                //the offset - given by the char constant '0'
                sum += s[i] - '0';

            }

            return sum;
        }

        //An easy step for Beginners
        /*

        Not converting the number to string

        int n = number;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            //Will use modulus to break the number into digits
            //n = 12345 % 10 -> 5
            //n = 1234 % 10 -> 4
            n %= 10;
            
            //Will add the digits
            //sum = 0 + 5 -> 5
            //sum = 5 + 4 -> 9
            sum += n;
            
            //Will be used to shorten the number
            //n = 12345 / 10 -> 1234
            //n = 1234 / 10 -> 123 
            n /= 10;
        }

        return sum;

        */
    }
}