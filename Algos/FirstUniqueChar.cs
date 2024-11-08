using System.Collections.Generic;

namespace LearningAlgos
{
    internal static class FirstUniqueChar
    {
        public static int FirstUniqueCharacter(string s)
        {
            // Given a string s, find the first non-repeating character in it and return its index.
            // If it does not exist, return -1.
            // https://leetcode.com/problems/first-unique-character-in-a-string/description/

            var occurances = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (occurances.ContainsKey(c))
                {
                    // Who knew you could do stuff like this...
                    occurances[c]++;
                }
                else
                {
                    occurances[c] = 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (occurances[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}