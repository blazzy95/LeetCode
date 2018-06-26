using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 500. Keyboard Row
/// </summary>

namespace LeetCode
{
    class KeyboardRow
    {
        public static string[] FindWords(string[] words)
        {
            var w = words.ToList().ConvertAll(wd => wd.ToLower());
            List<string> ans = new List<string>();
            HashSet<char> row1 = new HashSet<char>(){ 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
            HashSet<char> row2 = new HashSet<char>(){ 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
            HashSet<char> row3 = new HashSet<char>() { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            int check1=0, check2 =0, check3 = 0, index =-1;
            int checksum = 0;

            foreach (var word in w)
            {
                index++;
                check1 = check2 = check3 = 0;
                foreach (var letter in word)
                {
                    if (row1.Contains(letter))
                        check1 = 1;
                    if (row2.Contains(letter))
                        check2 = 1;
                    if (row3.Contains(letter))
                        check3 = 1;
                    checksum = check1 + check2 + check3;
                    if (check1 + check2 + check3 > 1)
                        break;
                }
                if(checksum == 1)
                    ans.Add(words[index]);
            }
            return ans.ToArray();
        }
    }
}
