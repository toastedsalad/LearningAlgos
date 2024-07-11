using System;

namespace LearningAlgos
{
    internal class PlusOneInArray
    {
        public static int[] PlusOneInArrayOfDigits(int[] digits)
        {   // You are given a large integer represented as an integer array digits,
            // where each digits[i] is the ith digit of the integer.
            // The digits are ordered from most significant to least significant in left-to-right order.
            // The large integer does not contain any leading 0's.
            // https://leetcode.com/problems/plus-one/description/

            var lastMember = digits.Length - 1;

            for (int i = lastMember; i >= 0; i--)
            {
                digits[i]++;

                if (digits[i] < 10)
                {
                    return digits;
                }

                digits[i] = 0;

                if (i == 0)
                {
                    int[] newdigitArray = new int[digits.Length + 1];
                    newdigitArray[0] = 1;
                    Array.Copy(digits, 0, newdigitArray, 1, digits.Length);
                    return newdigitArray;
                }
            }

            return digits;
        }
    }
}