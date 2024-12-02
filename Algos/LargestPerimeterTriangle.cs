using System;
using System.Collections.Generic;

namespace LearningAlgos;

public class LargestPerimeterTriangle { 
    public static int LargestPerimeter(int[] nums) {
        var validTriangles = new List<int[]>();

        for (var a = 0; a < nums.Length - 2; a++) {
            for (var b = a + 1; b < nums.Length - 1; b++) {
                for (var c = b + 1; c < nums.Length; c++) {
                    if (nums[a] + nums[b] > nums[c] && 
                            nums[a] + nums[c]  > nums[b] && 
                            nums[b] + nums[c] > nums[a]) {

                        validTriangles.Add(new int[] { nums[a], nums[b], nums[c] });
                    }
                }
            }

        }

        int maxSum = 0;

        foreach (var triangle in validTriangles) {
            int currentSum = triangle[0] + triangle[1] + triangle[2];

            maxSum = Math.Max(maxSum, currentSum);
        }

        if (validTriangles.Count == 0) {
            return 0;
        }

        return maxSum;
    }

    public static int LargestPerimeterWSort(int[] nums) {
        Array.Sort(nums);

        for (int i = nums.Length - 1; i >= 2; i--) {
            if (nums[i - 1] + nums[i - 2] > nums[i]) {
                return nums[i] + nums[i - 1] + nums[i - 2];
            }
        }

        return 0;
    }
}
