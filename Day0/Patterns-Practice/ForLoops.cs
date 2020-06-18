using System;

namespace loops_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            *****
             ***
              *

            */

            for(int i = 3; i >= 1; i--)
            {
                for(int k = 3; k > i; k--)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j < i*2; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            /*

            *****
            ****
            ***
            **
            *

            */

            for(int i = 5; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.WriteLine('*');
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            /*

              *
             ***
            *****

            */

            for(int i = 1; i <= 3; i++)
            {
                for(int j = 3; j > i; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k < i*2; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            /*

               *
              ***
             *****
            *******
             *****
              ***
               *

            */

            //Try to improve further

            for(int i = 1; i < 8; i++)
            {
                //if (i < 4)
                if(i < 4)
                {
                    for(int j = 4; j > 1; j--)
                    {
                        Console.Write(" ");
                    }
                    for(int k = 1; k < i*2; k++)
                    {
                        Console.Write('*');
                    }

                Console.WriteLine();
                }
                //if (i > 4)
                else if (i > 4)
                {
                    for(i = 4; i >= 1; i--)
                    {
                        for(int k = 4; k > i; k--)
                        {
                            Console.Write(" ");
                        }
                        for(int j = 1; j < i*2; j++)
                        {
                            Console.Write('*');
                        }

                        Console.WriteLine();
                    }

                break;
                
                }
            }
        }
    }
}