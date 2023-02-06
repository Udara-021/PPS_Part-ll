using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgrms
{
   public static class P0005_String_Trim
    {
        //C# Program Trims the Given String.

//        Explanation
//This C# program is used to trim the given string.
//            We have already defined a sentence using ‘myString’ variable. 
//        Then the trim() function is used to remove the spaces in the string.
        public static void String_Trim()
        {
            string myString = "      CSHARP     ";
            Console.WriteLine("the String before Trimming : " + "(" + myString + ")");

            Console.WriteLine("the String after Trimming : " + "(" + myString.Trim() + ")");
            Console.Read();
        }
    }
}
