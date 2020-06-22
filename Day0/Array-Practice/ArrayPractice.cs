using System;

namespace miscellaneous
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = new int[2];
            n = GetData();
            Console.WriteLine("Values of n");
            Console.WriteLine(n[0]);
            Console.WriteLine(n[1]);
            Console.WriteLine("Length of n");
            Console.WriteLine(n.Length);

            var m  = new int[10]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine("Values of m:");
            foreach (int value in  m)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("------------\n\n");
            var copym = new int[5];
            Array.Copy( m, copym, 5);
            Console.WriteLine("Values of copym");
            foreach (int value in  copym)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("------------\n\n");
            var concopym = new int[5];
            Array.ConstrainedCopy(m, 5, concopym, 0, 5);
            Console.WriteLine("Values of concopym");
            foreach (int value in concopym)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("-------------\n\n");

        }

        public static int[] GetData()
        {
            return new int[]{5, 6};
        }
    }
}
