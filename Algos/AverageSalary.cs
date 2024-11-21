namespace LearningAlgos{
    public class AverageSaraly(){
        public double Average(int[] salary){
            var searchScope = salary.Length;
            
            while(searchScope > 1) {
                for (int i = 0, j = 1; j < searchScope; i++, j++) {
                    // If i is bigger than j we swap. Else we just increment.
                    if (salary[i] > salary[j]) {
                        var firstValue = salary[i];
                        var secondValue = salary[j];
                        salary[i] = secondValue;
                        salary[j] = firstValue;
                    }
                }
                searchScope -= 1;
            }

            double sumNoEnds = 0;

            for (var i = 1; i < salary.Length - 1; i++) {
                sumNoEnds += salary[i];
            }

            double average = sumNoEnds / (salary.Length - 2);
            return average;
        }

    }
}
