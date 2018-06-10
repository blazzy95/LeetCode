using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// Leet code 804. Unique Morse Code Words
/// </summary>


namespace ConsoleApp4
{
    class UniqueMorseCodeWords
    {
        public static int UniqueMorseRepresentations(string[] words)
        {
            string[] morseCode = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            HashSet<string> set = new HashSet<string>();
            
            foreach (string word in words)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < word.Length; i++)
                {
                    sb.Append(morseCode[word[i] - 'a']);
                }

                if (!set.Contains(sb.ToString()))
                    set.Add(sb.ToString());

            }

            return set.Count;
        }
    }
}
