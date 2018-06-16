using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// 461. Hamming distance
/// </summary>

namespace ConsoleApp4
{
    class HammingDistance
    {

        public static int GetHammingDistance(int x, int y)
        {
            int res = 0;
            int ans = x ^ y;
            for (int i = 0; i < 32; ++i)
            {
                res += (ans >> i) & 1;
            }
            return res;
        }
    }
}
