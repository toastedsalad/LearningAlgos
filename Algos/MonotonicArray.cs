using System;

namespace LearningAlgos;

public class MonotonicArrayFinder
{
    public static bool IsArrayMonotonic(int[] nums)
    {
        var decreasingArray = false;
        var increasingArray = false;

        int i = 0;
        int j = 1;

        // First determmine the direction of the array.
        for(; j < nums.Length; i++, j++)
        {   
            if (nums[i] == nums[j])
            {
                continue;
            }
            if (nums[i] < nums[j])
            {
                increasingArray = true;
                i++;
                j++;
                break;
            }
            else
            {
                decreasingArray = true;
                i++;
                j++;
                break;
            }
        }

        // Handle the different types of arrays individually.
        if (decreasingArray)
        {
            for(; j < nums.Length; i++, j++)
            {
                if(nums[i] < nums[j])
                {
                    return false;
                }
            }
        }

        if (increasingArray)
        {
            for(; j < nums.Length; i++, j++)
            {
                if(nums[i] > nums[j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}
