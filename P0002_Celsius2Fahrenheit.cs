using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgrms
{
    public class P0002_Celsius2Fahrenheit
    {
        public  void Cel_to_Fahit()
        {
            //This C# Program Performs Celsius to Fahrenheit Conversion.
            int celsius, faren;
            Console.WriteLine("Enter the Temperature in Celsius(C) : ");
            celsius = int.Parse(Console.ReadLine());
            faren = (celsius * 9) / 5 + 32;
            Console.WriteLine("Temperture in fahrenhit is (F) : " + faren); 
        }
    }
}
