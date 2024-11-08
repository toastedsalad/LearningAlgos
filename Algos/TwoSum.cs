
using System.Collections.Generic;

namespace LearningAlgos;

public class TwoSum
{
    public static int[] TwoSumQuadratic(int[] nums, int target) 
    {
        // For a quadratic solution we add the first element with each other element
        // And then check if it is the target.
        // If it is not then we remove the first element and try again.

        for (int i = 0; i < nums.Length - 1; i++)
        {
            // Here we need to take the i and add it with each other element
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }
        return null;
    }

    public int[] TwoSumLinearProer(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        // [2,11,15,7]
        for(int i = 0; i <= nums.Length; i++)
        {  
            // x = 9 - 2
            int x = target - nums[i];
            // Check if map contains 7;
            if(map.ContainsKey(x) ){
               return new int[] {map[x], i};
            }

            if (!map.ContainsKey(nums[i])){
               map[nums[i]] = i;
            }
        }

        return new int[0];
    }

    public static int[] TwoSumLinear(int[] nums, int target)
    {
        // Do we need to try all possible pairs?
        // For zero based pairs we need to find position of zero.
        // And then position of target.
        var result = new int[2];
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
            {
                result[0] = i;
                for(int j = 0; j < nums.Length; j++)
                {
                    if(j != result[0] && nums[j] == target - 0)
                    {
                        result[1] = j;
                        return result;
                    }
                }
            }
        }

        var occurances = new Dictionary<int, int>();
        // Translate the original array into a dict
        // Take the int as the key
        // Take the position as value
        for (int i = 0; i < nums.Length; i++)
        {
            if (occurances.ContainsKey(nums[i]))
            {
                occurances[nums[i]]++;
            }
            else
            {
                occurances[nums[i]] = 1;
            }
        }

        // Once we have occurances we can check if the number is divisible by two
        // If it is, we can look for two occurances of the quotient. 
        if (target % 2 == 0)
        {
            var divided = target/2;
            if(occurances.ContainsKey(divided) && occurances[divided] > 1)
            {
                for(int i = 0; i < nums.Length; i++)
                {
                    if(nums[i] == divided)
                    {
                        result[0] = i;
                        for(int j = i + 1; j < nums.Length; j++)
                        {
                            if(nums[j] == divided)
                            {
                                result[1] = j;
                                return result;
                            }
                        }
                    }
                }
            }
        }

        // For the rest of the cases we
        // create an array of differences of target - i
        // Idea being that his array will hold duplicates of sum pairs.
        // [2,11,15,7]
        // [7,-2,-6,2]
        // Notice 2 and 7. Having this info we can lookup duplicates to find positions. 
        var oppositeArray = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            oppositeArray[i] = target - nums[i];
        }
 
        for(int i = 0; i < oppositeArray.Length; i++)
        {
            // We discard if the value at the same index is the same for both
            // The original array and the array of opposites
            if(occurances.ContainsKey(oppositeArray[i]) && oppositeArray[i] != nums[i])
            {
                result[0] = i;
                for(int j = 0; j < oppositeArray.Length; j++)
                {
                    if(j != result[0] && oppositeArray[j] != nums[j])
                    {
                        if(occurances.ContainsKey(oppositeArray[j]))
                        {
                            result[1] = j;
                            return result;
                        }
                    }
                }
            }
        }

        return result;
    }
}
