using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 520. Detect Capital
/// </summary>

namespace leetcodeLocal
{
    public class DetectCapital
    {
        public static bool DetectCapitalUse(string word)
        {
            bool res1 = true, res2 = true, res3 = true;

            //Check if all are capital
            foreach (var l in word)
            {
                if (l < 60 || l > 90)
                {
                    res1 = false;
                    break;
                }

            }

            //Check if starting is capital and remaining letters are lower case
            if (word[0] >= 60 && word[0] <= 90)
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if (word[i] >= 60 && word[i] <= 90)
                    {
                        res2 = false;
                        break;
                    }
                }
            }
            else
            {
                res2 = false;
            }

            //check if all are lower case
            foreach (var l in word)
            {
                if ((l >= 60 && l <= 90))
                {
                    res3 = false;
                    break;
                }
            }

            return res1||res2||res3;
        }
    }
}
