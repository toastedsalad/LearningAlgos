using System.Collections.Generic;

namespace LearningAlgos{
    public static class KthFactor{
        public static int GetKthFactor(int n, int k){
            var listOfFactors = new List<int>();

            for (var i = n; i > 0; i--) {
                if (n % i == 0) {
                    listOfFactors.Add(i);
                }
            }

            // Return -1 if there are less items in the list than k
            if (listOfFactors.Count < k) {
                return -1;
            }

            listOfFactors.Reverse();

            return listOfFactors[k];
        }
    }
}
