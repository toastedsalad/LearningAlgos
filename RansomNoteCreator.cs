using System.Collections.Generic;

namespace LearningAlgos
{
    internal class RansomNoteCreator
    {

        public bool CanCOnstructRansomNoteHashMap(string ransomNote, string magazine)
        {
            if (magazine.Length < ransomNote.Length)
            {
                return false;
            }

            var magazineLetters = new Dictionary<char, int>();


            // Here we calculate frequency of all letters in a magazine.
            for (int i = 0; i < magazine.Length; i++)
            {
                var letterMag = magazine[i];

                // We count the current amount of letterMag or set it to zero:
                int currentCount = magazineLetters.GetValueOrDefault(letterMag, 0);

                // If we found something we increment by one.
                magazineLetters[letterMag] = currentCount + 1;
            }

            // Here we check if the demand for letters is sufficient
            for (int i = 0; i < ransomNote.Length; i++)
            {
                var letterRan = ransomNote[i];

                int letterCount = magazineLetters.GetValueOrDefault(letterRan, 0);

                if (letterCount == 0)
                {
                    return false;
                }

                // Do not forget to decrement the letterCount
                magazineLetters[letterRan] = letterCount - 1;
            }

            return true;

            // Time complexity O(n) because we must go over each letter of the magazine once. Complexity depends on the length of the magazine.
            // We can also return false immediately if magazine is lower in length than the ransome note.

            // Space complextity O(k) where k is the number of distinct characters in the magazine.
        }
    }
}