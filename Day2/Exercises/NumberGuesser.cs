using System;

namespace Task07
{
    /*

    7. Guess a number

    Write a guess-a-number game. 
    The .NET random generator is available by generating a new instance of the Random class. 
    The game should give the user the opportunity to enter the range of numbers. 
    Based on this range the number of tries should be determined (you can decide how hard the game should be). 
    For each try the user has the ability to guess a number. 
    If the guessed number is the generated number, then the user won the game. 
    If the number of tries has been exceeded, the user lost the game.

    */

    internal class NumberGuesser
    {
        //This can be called like NumberGuesser.Game()
        public static void Game()
        {
            //Generate an instance of the Random number generator class
            Random r = new Random();

            //Some output
            Console.WriteLine("What is the lowest number?");
            int lower;

            //If this is an invalid input, return
            if (!int.TryParse(Console.ReadLine(), out lower))
            {
                Console.WriteLine("The lower number is invalid.");
                return;
            }

            Console.WriteLine("What is the highest number?");
            int upper;

            //If this is an invalid input, return
            if (!int.TryParse(Console.ReadLine(), out upper))
            {
                Console.WriteLine("The upper number is invalid.");
                return;
            }

            //Generate the real value (random number)
            int num = r.Next(Math.Min(lower, upper), Math.Max(upper, lower) + 1);
            //the number of tries is given by the # of values / 3
            int tries = Math.Max((upper - lower) / 3, 1);

            //The number of tries is positive
            while (tries > 0)
            {
                Console.WriteLine("Still {0} tries available. What is your guess?", tries);
                int guess;

                //Try to parse the value
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Not a valid number.");
                }

                tries--;

                if (guess == num)
                {
                    Console.WriteLine("YOU JUST GOT IT ... RIGHT! :D");
                    break;
                }
                else
                {
                    Console.WriteLine("TRY AGAIN :(");
                }
            }
        }
    }
}