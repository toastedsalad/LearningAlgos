using System;

namespace LearningAlgos
{
    // Find a value in an array lineary.
    // This is probably what IndexOf() is doing.
    // O(N) linear growth.
    public static class LinearSearchAlgo
    {
        public static bool SearchLinearly(int[] haystack, int needle)
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle)
                {
                    Console.WriteLine("Found the needle.");
                    return true;
                }
            }

            Console.WriteLine("Did not find the needle.");
            return false;
        }
    }
}

