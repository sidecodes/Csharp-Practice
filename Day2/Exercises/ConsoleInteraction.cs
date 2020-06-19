using System;

namespace Task10
{
    /*

    10. A useful class

    Create a class, which simplifies receiving user input in the console. 
    The class should have a default constructor and another constructor, which requires a string to be passed. 
    The given string should be used as the message for the user the prompt. 
    In case of the default constructor a default message should be displayed.

    The class should have a method called ParseInt() and another method called ParseDouble().
    The ParseInt() method will try to get a valid integer value.
    If no valid integer value is passed in, it will display an error message and prompt the user to enter a valid integer value.
    Once a valid integer value is passed in, this loop is broken and the value is returned. 
    The ParseDouble() method does the same with a floating point value instead of an integer.

    */

    internal class ConsoleInteraction
    {
        //Field to store the message
        string message;

        //Standard constructor
        public ConsoleInteraction()
            : this("Please enter a valid number")
        {
        }

        /*

        //Easy and Begineer friendly
        //Default constructor
        public ConsoleInteraction()
        {
            message = "Please enter a valid number";
        }

        */

        // Constructor that sets the message to custom value
        public ConsoleInteraction(string message)
        {
            this.message = message;
            ErrorMessage = "Invalid number! Try again ...";
        }

        public string ErrorMessage
        {
            get;
            set;
        }

        //Parses an integer input
        public int ParseInt()
        {
            // As long as no integer has been inserted
            while (true)
            {
                //Check that
                int tmp;
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (int.TryParse(input, out tmp))
                    return tmp;

                //Output an error !!
                Console.WriteLine(ErrorMessage);
            }
        }

        //Parses a double input

        public double ParseDouble()
        {
            // As long as no double has been inserted
            while (true)
            {
                //Check that
                double tmp;
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (double.TryParse(input, out tmp))
                    return tmp;

                //Output an error !!
                Console.WriteLine(ErrorMessage);
            }
        }
    }
}