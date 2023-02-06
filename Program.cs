using System;

namespace CSharpProgrms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World hi!");
            // 01- this programme for check given integer is Even or Odd
            //int EntNum;
            //Console.Write("Enter a Number..");
            //EntNum = int.Parse(Console.ReadLine());

            //when static 
            //P0001_Check_Even_Odd.Check_Even_Odds(EntNum);
            //Console.ReadLine();

            //when Non static 
            //Calculations calc = new Calculations();
            //calc.Check_Even_Odd(EntNum);
            //Console.ReadLine();

            // 02- This C# Program Performs Celsius to Fahrenheit Conversion.
            //P0002_Celsius2Fahrenheit obj = new P0002_Celsius2Fahrenheit();
            //obj.Cel_to_Fahit();

            //0003
            //P0003_Reverse_IntArray.Reverse_String();

            //0004
            //P0004_String_without_Reverse_Function.String_without_Reverse__Function();

            //0005
            P0005_String_Trim.String_Trim();
        }

        //this programme for check given integer is Even or Odd
      //public class Calculations
        public static class xCalculations
        {
            public static void Check_Even_Odd(int numb)
            {
                if (numb % 2 == 0)
                {
                    Console.Write("You Entered Number is an Even Number");
                    Console.Read();
                }
                else
                {
                    Console.Write("You Entered Number is an Odd Number");
                    Console.Read();
                }
            }
        }
    }
}
