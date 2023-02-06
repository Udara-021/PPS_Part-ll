using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgrms
{
   public static class P0004_String_without_Reverse_Function
    {
        //This C# Program Reverses a String without using Reverse function. 

//        Explanation
//In this C# program, we are reading a string using ‘str’ variable.
//Using while loop the string is reversed by changing the position of characters from right to left one by one.
//The iteration of the loop will continue till the condition becomes false.
        public static void String_without_Reverse__Function()
        {
            string Str, reversestring = "";
            int Length;
            Console.Write("Enter a String : ");
            Str = Console.ReadLine();
            Length = Str.Length - 1;
            while(Length >= 0)
            {
                reversestring = reversestring + Str[Length];
                Length--;
            }
            Console.WriteLine("Reverse String is {0}", reversestring);
            Console.ReadLine();
        }
    }
}
