using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAlgos
{
    public static class ArraySigner
    {
        // Determine the sign of the array product.
        public static int ArraySign(int[] nums)
        {
            int sign = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    return 0;
                }
                if (nums[i] < 1)
                {
                    sign = sign * -1;
                }
            }

            return sign;
        }
    }
}
