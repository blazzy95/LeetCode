using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// 806. Number of Lines To Write String
/// </summary>

namespace ConsoleApp4
{
    class NumberOfLinesToWriteString
    {
        public static int[] NumberOfLines(int[] widths, string S)
        {
            int lines = 1, units = 0;
            for (int i = 0; i < S.Length; i++)
            {
                units += widths[S[i] - 'a'];
                if (units > 100) 
                {
                    units = 0; ;
                    lines++; 
                    i--; 
                }
            }
            return new int[] { lines, units };
        }
    }
}
