using System;
using System.Collections.Generic;
namespace RomanToString
{
    class RomanToString
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("IX"));
            Console.ReadKey();
        }

        private static int RomanToInt(string rom)
        {
            Dictionary<char, int> romansDict = new Dictionary<char, int>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
            int res = 0;
            for(int i = 0;i<rom.Length;i++)
            {
                res += romansDict[rom[i]];
                if (i != 0 && romansDict[rom[i]] > romansDict[rom[i-1]])
                    res -= 2 * romansDict[rom[i-1]];
            }


            return res;

        }
    }
}
