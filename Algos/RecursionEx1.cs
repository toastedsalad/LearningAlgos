using System;

namespace LearningAlgos {
    public class Subtractor {
        public static int SubtractUntilOne(int n) {
            // Base Case:
            if (n == 1) {
                Console.WriteLine($"Post step output log: {n}");
                return 1;
            }

            var result = n + SubtractUntilOne(n - 1);
            Console.WriteLine($"Post step output log: {n}");
            return result;
        }
    }
}
