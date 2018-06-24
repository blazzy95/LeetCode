using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// 338. Counting Bits
/// </summary>

namespace ConsoleApp4
{
    class CountingBits
    {
        public static int[] countBits(int num)
        {
            int[] result = new int[num+1];
            int pow = 1; int exp = 1;
            int index = 1;

            for(int i = 1;i<=num;i++)
            {
                if (i == pow) //reset
                {
                    result[i] = 1;
                    index = 1;
                    pow = (int)Math.Pow(2, exp++);
                    
                }
                else
                {
                    result[i] = result[index] + 1;
                    index++;
                }
            }
            return result;
        }
    }
}
