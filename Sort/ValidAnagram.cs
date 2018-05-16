using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// 242. Valid Anagram
/// </summary>
/// 
namespace Sort
{
    class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            //add string s in dict
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]]++;
                }
                else
                {
                    dict.Add(s[i],1);
                }
            }

            //check with string t in dict
            for(int i = 0;i<t.Length;i++)
            {
                if (dict.ContainsKey(t[i]))
                {
                    if (dict[t[i]] == 1)
                        dict.Remove(t[i]);
                    else
                        dict[t[i]]--;
                }
                else
                    return false;
            }

            if (dict.Count > 0)
                return false;
            else
                return true;



        }
    }
}
