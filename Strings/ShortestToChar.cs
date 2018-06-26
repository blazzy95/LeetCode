using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 821. Shortest Distance to a Character
/// </summary>

namespace LeetCode
{
    class Program
    {
        public static int[] ShortesttoChar(string S, char C)
        {
            int[] result = new int[S.Length];

            int lastC = -1;
            int lastNonC = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == C)
                {
                    while (lastNonC <= i)
                        result[lastNonC] = Math.Min(result[lastNonC], i - lastNonC++);
                    lastC = i;
                }
                else
                {
                    result[i] = lastC != -1 ? i - lastC : Int32.MaxValue;
                }
            }

            return result;
        }
    }
}