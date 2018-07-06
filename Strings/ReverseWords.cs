using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 557. Reverse Words in a String III
/// </summary>

namespace leetcodeLocal
{
    class ReverseWords
    {
        public static string ReverseWords(string s)
        {
            string[] words = s.Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach (var word in words)
            {
                sb.Append(Reverse(word));
                sb.Append(" ");
            }

            return sb.ToString().TrimEnd();
        }

        public static string Reverse(string s)
        {
            if (s == null) return null;
            char[] charArray = s.ToCharArray();
            int len = s.Length - 1;

            for (int i = 0; i < len; i++, len--)
            {
                charArray[i] ^= charArray[len];
                charArray[len] ^= charArray[i];
                charArray[i] ^= charArray[len];
            }

            return new string(charArray).TrimEnd();
        }
    }
}
