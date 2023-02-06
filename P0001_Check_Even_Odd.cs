using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgrms
{
    public class P0001_Check_Even_Odd
    {
        //this programme for check given integer is Even or Odd
        public static void Check_Even_Odds(int numb)
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
