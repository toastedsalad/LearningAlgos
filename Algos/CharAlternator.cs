using System;
using System.Text;

namespace LearningAlgos
{
    internal class CharAlternator
    {

        public static string Alternate(string word1, string word2)
        {
            // You are given two strings word1 and word2.
            // Merge the strings by adding letters in alternating order,
            // starting with word1. If a string is longer than the other,
            // append the additional letters onto the end of the merged string.
            // https://leetcode.com/problems/merge-strings-alternately/description/

            StringBuilder result = new StringBuilder();

            int maxLength = Math.Max(word1.Length, word2.Length);
            for (int i = 0; i < maxLength; i++)
            {
                if (i < word1.Length)
                {
                    result.Append(word1[i]);
                }
                if (i < word2.Length)
                {
                    result.Append(word2[i]);
                }
            }

            return result.ToString();
        }
    }
}