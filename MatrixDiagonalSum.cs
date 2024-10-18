namespace LearningAlgos{
    public class MatrixDiagonalSum(){
        public int DiagonalSum(int[][] mat){
            // One way of doing is to go from front and back at the same time
            // Check if the coordinates are equal and if they are add only once
            int sum = 0;
            int startIndex = 0;
            int endIndex = mat[0].Length - 1;
                    
            for(var i = 0; i < mat.Length; i++){
                // Here we need to take the first element of the inner array
                // Take the last element of the inner array 
                // Compare their coordinaters and if they don't match
                // Add both to the sum
                // If they match add value only once

                var startValue = mat[i][startIndex];
                var endValue = mat[i][endIndex];

                if(startIndex == endIndex){
                    sum += startValue;
                }
                else{
                    sum += startValue;
                    sum += endValue;
                }
                endIndex--;
                startIndex++;
            }
            return sum;
        }
    }
}
