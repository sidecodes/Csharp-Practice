using System;

namespace Task03
{
    /*
    3. Currency converter

    Write a little currency converter as a console application.
    The user should be asked to enter a value.
    Once a value has been entered the user is requested to enter a valid currency exchange rate.
    Afterwards the converted value should be displayed. Finally, if no error occurred, ask the user if another value should be converted.
    If yes, then start again by asking the user to enter a value. 
    Otherwise exit the program.

    */
    internal class CurrencyConverter
    {
        //static method to call it like CurrencyConverter.Interaction()
        public static void Interaction()
        {
            //Infinite loop (until user does not want to continue or makes a mistake)
            while (true)
            {
                //Some output
                Console.WriteLine("Enter the amount of money to convert:");
                double amount;

                //Try to convert the input to its double-precision floating-point number equivalent
                //by using TryParse() and if so - continue
                if (!double.TryParse(Console.ReadLine(), out amount))
                {
                    //Otherwise output an error and break the loop
                    Console.WriteLine("An error occured. The amount of money has to be a number.");
                    break;
                }

                Console.WriteLine("Enter the currency exchange rate:");
                double rate;

                //Try to convert the input using TryParse() and if so - continue
                if (!double.TryParse(Console.ReadLine(), out rate))
                {
                    //Otherwise output an error and break the loop
                    Console.WriteLine("An error occured. The exchange rate has to be a number.");
                    break;
                }

                //Display converted result
                Console.WriteLine("The converted amount of money is:");
                double converted = amount * rate;
                Console.WriteLine(converted);
                //Ask user if he wants to continue
                Console.WriteLine("Convert another ? (y/n)");
                string input = Console.ReadLine();

                //if not then break
                if (input != "y" && input != "Y")
                    break;
            }
        }
    }
}