using System;

namespace LearningAlgos
{
    internal class ZeroMover
    {

        public void MoveZeroes(int[] nums)
        {
            // Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
            // Note that you must do this in-place without making a copy of the array.

            // We track an index of the last moved non zero int.
            var index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[index] = nums[i];
                    index++;

                    // Can be optimized as this but personally
                    // This is not as clear to me...
                    // nums[index++] = nums[i];
                }
            }

            // We start iterating from the last non zero index.
            // Fill the rest with zeroes.
            for (int i = index; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            Console.WriteLine(string.Join(", ", nums));

            // Complexity is O(N) we itereate through a list linearly.
            // Space complexity is O(1) where 1 is the orrignal array.
        }
    }
}