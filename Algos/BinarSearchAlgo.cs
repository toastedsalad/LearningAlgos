using System;

namespace LearningAlgos
{
    public static class BinarSearchAlgo
    {
        public static int Search(int[] nums, int target)
        {
            decimal lo = 0;
            decimal hi = nums.Length;

            while (lo < hi) // Using the exclusive upper bound.
            {
                // Not understanding the mid point math.
                // We use (hi - lo) / 2 to avoid addition of large numbers
                // It can cause integer overflow.
                // So we just add half the distance between high and low.
                var middleIndex = (int)Math.Floor(lo + (hi - lo) / 2);
                var middleValue = nums[middleIndex];

                // If the value and our target match 
                if (middleValue == target)
                {
                    return middleIndex;
                }
                // If our value is bigger than the target.
                // It means we should be looking to the left.
                // We keep lo the same 
                // Set hi to the middle.
                else if (middleValue > target)
                {
                    hi = middleIndex;
                }
                // Else we set the lower bound and look for target on the right
                // We add one cause we already know the middle index is not the target
                else
                {
                    lo = middleIndex + 1;
                }
            }
            
            return -1; // Somehow this is called a sentinel value.
        }
    }
}


