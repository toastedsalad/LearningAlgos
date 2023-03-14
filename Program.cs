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
            var result = program.FizzBuzzWList(15);
            Console.WriteLine(string.Join("\n", result));

            // NumberOfSteps
            //var result = program.NumberOfSteps(8);
            //Console.WriteLine(result);

            // NumberOfSteps
            //var result = program.NumberOfStepsBitWise(14);
            //Console.WriteLine(result);
        }

        public int NumberOfStepsBitWise(int num)
        {
            var steps = 0;

            while (num > 0)
            {   // We apply a bit mask of 00000001 or just 1 to check if the right most bit is 1 or 0
                // 1 & 1 is 1
                // 0 & 1 is 0
                // Because the right most bit allways adds 1 to the total value of bits
                // when we do get 1 it means the number is odd
                // and when we get 0 it means the number was even
                if ((num & 1 ) == 0) 
                {
                    // If the number was even we can halve it by shifting all bits 
                    // to the right by one place.
                    // It works because binary is power of 2 
                    // so the previous place is always half of the curent number.
                    num >>= 1;
                }
                else
                {
                    num--;
                }

                steps++;
            }
            return steps;
        }

        public int NumberOfSteps(int num)
        {
            var steps = 0;

            while(num > 0)
            {   // check if divisible by two
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num--;
                }
                steps++;
            }
            return steps;
        }

        public List<string> FizzBuzzWList(int n)
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

        public string[] FizzBuzz(int n)
        {
            var currentArray = new string[n];

            for (int i = 1; i <= n; i++)
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

                currentArray[i - 1] = currentString.ToString();
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
