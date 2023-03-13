using System;
using System.Collections.Generic;
using System.Text;

namespace LearningAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();

            // RunningSum
            //int[] nums = { 1, 2, 3, 4 };
            //var result = program.RunningSum(nums);
            //Console.WriteLine(result);

            // MaxWealth
            //int[] a = { 1, 2, 3 };
            //int[] b = { 3, 2, 1 };
            //int[][] accounts = { a, b };
            //var result = program.GetMaxWealth(accounts);
            //Console.WriteLine(result);

            // FizzBuzz
            var result = program.FizzBuzz(15);
            Console.WriteLine(string.Join("\n", result));
        }

        public List<string> FizzBuzz(int n)
        {
            var currentArray = new List<string>(n);

            for (int i=1; i <= n; i++)
            {
                var currentString = new StringBuilder();

                Boolean divisibleBy3 = i % 3 == 0;
                Boolean divisibleBy5 = i % 5 == 0;

                if (divisibleBy3)
                {
                    currentString.Append("Fizz");
                }
                if (divisibleBy5)
                {
                    currentString.Append("Buzz");
                }
                if (currentString.Length == 0)
                {
                    currentString.Append(i);
                }

                currentArray.Add(currentString.ToString());
            }

            return currentArray;
        }

        public int GetMaxWealth(int[][] accounts)
        {
            var maxWealthSoFar = 0;

            foreach(int[] customer in accounts)
            {
                var currentCustomerWealth = 0;
                foreach(int bank in customer)
                {
                    currentCustomerWealth += bank;
                }
                maxWealthSoFar = Math.Max(maxWealthSoFar, currentCustomerWealth);
            }

            return maxWealthSoFar;
        }

        public int[] RunningSum(int[] nums)
        {
            var result = new int[nums.Length];
            result[0] = nums[0];

            Console.WriteLine(nums.Length);

            for (int i = 1; i < nums.Length; i++)
            {
                // We need to add the current index to the previous index
                //Console.WriteLine(result[i - 1] + nums[i]);
                var myVar = result[i - 1] + nums[i];
                result[i] = myVar;
            }
            return result;
        }
    }
}
