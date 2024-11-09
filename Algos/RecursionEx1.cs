namespace LearningAlgos {
    public class Subtractor {
        public static int SubtractUntilOne(int n) {
            // Base Case:
            if (n == 1) {
                return 1;
            }
            return n + SubtractUntilOne(n - 1);
        }
    }
}
