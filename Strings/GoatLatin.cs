using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// 824. Goat Latin
/// </summary>

namespace ConsoleApp4
{
    class GoatLatin
    {
        public static string ToGoatLatin(string S)
        {
            string[] words = S.Split(' ');
            int index = 1;
            HashSet<char> vowels = new HashSet<char>() { 'a', 'e', 'i','o', 'u','A','E','I','O','U' };
            StringBuilder sb = new StringBuilder();

            foreach(var word in words)
            {
                if(vowels.Contains(word[0]))
                {
                    sb.Append(word).Append("ma");
                }
                else
                {
                    sb.Append(word.Substring(1)).Append(word[0]).Append("ma");
                }
                
                for (int i = 0; i < index; i++)
                    sb.Append("a");
                index++;
                sb.Append(" ");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
