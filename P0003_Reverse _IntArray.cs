using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgrms
{
   public static class P0003_Reverse_IntArray
    {
        //This C# Program Reverses a String with Predefined Function.
        public static void Reverse_String()
        {
            Console.WriteLine("Enter Number of elements you want to Hold in the Array? ");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            int[] a = new int[x];

            Console.WriteLine("\n Enter Array Elemernts : ");
            for (int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
            Array.Reverse(a);
            Console.WriteLine("Reverse Array : ");
            for(int i = 0; i < x; i++)
            {
                Console.WriteLine("Element {0} is {1}", i + 1, a[i]);
            }
            Console.Read();
        }

//        Explanation
//This C# program, we are reading the size of an array using ‘s’ variable. Using for loop we are entering the coefficient values of an array.
//The string is reversed using the predefined function reverse() by passing the value of ‘a’ variable as an argument.
//Another for loop is used to print the reverse of a string.


    }
}
