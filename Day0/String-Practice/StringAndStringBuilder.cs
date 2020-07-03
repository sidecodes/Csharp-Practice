using System;
using System.Text;
using System.Collections;

namespace StringandStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = "h";
            // Append to contents of 'b'
            b += "ello";
            Console.WriteLine(a == b);
            Console.WriteLine(object.ReferenceEquals(a, b));

            string c = "good " + "morning";
            string d = "h";
            d += "ello";

            string str1 = "test";
            char x = str1[2]; // x = 's';
            
            string str2 = "test";

            for (int i = 0; i < str2.Length; i++)
            {
                Console.Write(str2[i] + " ");
            }
            // Output: t e s t

            var vs = "good morning"; // a string literal
            
            //  \\ for backslash, \u0066 for f \n new line
            string strf = "\\\u0066\n F";
            Console.WriteLine(a);
            // Output:
            // \f
            // F

            var vsl = @"good morning"; // a string literal
            // Usage -> The advantage of verbatim strings is that escape sequences are not processed, which makes it easy to write, for example, a fully qualified Windows file name:
            var vs2 = @"c:\Docs\Source\a.txt"; // rather than "c:\\Docs\\Source\\a.txt"
            // To include a double quotation mark in an @-quoted string, double it:
            var vs3 = @"""Ahoy!"" cried the captain."; // "Ahoy!" cried the captain.

            // String
            string strA = new string("ABC");
            string strB = "XYZ";
            string strC;
            strC = String.Concat(strA, strB);
            
            // StringBuilder
            StringBuilder strD = new StringBuilder("ABC");
            StringBuilder strE = new StringBuilder("XYZ");
            StringBuilder strF;
            strF = strD.Append(strE);

            Console.WriteLine("==========================");

            Console.WriteLine("String Multiplication:");

            // Stringbuilder creates a resizeable array to mutate strings

            // Create "hellohellohellohello"
            StringBuilder sb1 = new StringBuilder();
            for(int i = 0; i < 4; i++){
                sb1.Append("hello");
            }

            Console.WriteLine(sb1);

            Console.WriteLine("==========================");

            Console.WriteLine("String Manipulation:");
            // Change "Herlo" to "Hello"

            // 1st method using substrings
            string s1 = "Herlo";
            s1 = s1.Substring(0,2) + "l" + s1.Substring(3);

            Console.WriteLine(s1);

            // 2nd method using stringbuilder
            String s2 = "Herlo";
            StringBuilder sb = new StringBuilder(s2);
            sb.Replace('r','l');
            s2 = sb.ToString();

            Console.WriteLine(s2);

            Console.WriteLine("===========================");

            // Instantiate a String object
            /* 
            
            By assigning a string literal to a String variable.
            This is the most commonly used method for creating a string. 
            The following example uses assignment to create several strings. 
            Note that in C#, because the backslash (\) is an escape character, 
            literal backslashes in a string must be escaped or the entire string must be @-quoted.
            
            */
            
            string sa1 = "This is a string created by assigment.";
            Console.WriteLine(sa1);
            string s2a = "This path is C:\\PublicDocuments\\Record1.doc";
            Console.WriteLine(s2a);
            string s2b = @"The path is C:\PublicDocuments\Report1.doc";
            Console.WriteLine(s2b);
            // The example displays the following output:
            //      This is a string created by assignment.
            //      The path is C:\PublicDocuments\Report1.doc
            //      The path is C:\PublicDocuments\Report1.doc

            /*

            By calling a String class constructor. 
            The following example instantiates strings by calling several class constructors. 

            */
            char[] chars = { 'w', 'o', 'r', 'd' };
            sbyte[] bytes = { 0x41, 0x42, 0x43, 0x44, 0x45, 0x00 };

            // Create a string from a character array.
            string sc1 = new string(chars);
            Console.WriteLine(sc1);

            // Create a string that consists of a character repeated 20 times.
            string sc2 = new string('c', 20);
            Console.WriteLine(sc2);

            /*

            By using the string concatenation operator (+ in C#) to create a single string from any combination of String instances and string literals. 
            The following example illustrates the use of the string concatenation operator.

            */

            string ss = "Today is " + DateTime.Now.ToString("D") + ".";
            Console.WriteLine(ss);

            string ss2 = "This is one sentence. " + "This is a second. ";
            ss2 += "This is a third sentence.";
            Console.WriteLine(ss2);
            // The example displats output like the following:
            //      Today is Tuesday, July 06, 2011.
            //      This is one sentence. This a second. This a third sentance.

            /*

            By retrieving a property or calling a method that returns a string. 
            The following example uses the methods of the String class to extract a substring from a larger string.

            */

            string sentence = "This sentence has five words.";
            // Extract the second word.
            int startPosition = sentence.IndexOf(" ") + 1;
            string word2 = sentence.Substring(startPosition, 
                                                sentence.IndexOf(" ", startPosition) - startPosition);
            Console.WriteLine("Second word: " + word2);
            // The example displays the following output:
            //          Second word: sentence

            /*

            By calling a formatting method to convert a value or object to its string representation. 
            The following example uses the composite formatting feature to embed the string representation of two objects into a string.

            */

            DateTime dateAndTime = new DateTime(2010, 7, 6, 7, 32, 0);
            double temperature = 68.3;
            string result =  String.Format("At {0:t} on {0:D}, the temperature was {1:F1} degrees Fahrenheit",
                                            dateAndTime, temperature);
            Console.WriteLine(result);
            // The example displays the following output:
            //      At 7:32 AM on Wednesday, July 06, 2010, the temperature was 68.3 degrees Fahrenheit.


        }
    }
}
