using System.Collections.Generic;

namespace LearningAlgos{
    public class SpiralMatrix{
        public IList<int> SpiralOrder(int[][] matrix) {

            // How do I even do it...
            // For each subarray we need to figure out an algo for values to ignore
            // and values to take.
            //
            // [[x1,x2,x3][y1,y2,y3],[z1,z2,z3]]
            //
            // [x1,x2,x3]
            // [y1,y2,y3]
            // [z1,z2,z3]
            //
            //
            // [x1,x2,x3,y3,z3,z2,z1,y1,y2]
            //
            // We need to allways take full outside rows.
            //

            // First take the top row without the last element
            // Then take the last column of each sub array.
            // Then take thefirst column up
            // Then we somehow narrow the boundary and repeat
            //
            // The for the first run the start coordinate is (0, 0)
            // after the run we start at (1, 1)
            // how can we understand where to stop?
            // we stop when if bump into the same coordante

            var startCoordinate = new int[]{0, 0};
            var endCoordinate = new int[]{0, 1};
            var currentCoordinate = new int[]{0, 0};
            var subArrayLentgh = matrix[0].Length;
            var spiralList = new List<int>();

            while(currentCoordinate[0] <= endCoordinate[0] && currentCoordinate[1] <= endCoordinate[1]){
                for(var i = startCoordinate[0]; i < matrix[currentCoordinate[0]].Length; i++){
                    // First let's take whole first row
                    // repeat this until the end
                    spiralList.Add(matrix[currentCoordinate[0]][currentCoordinate[i]]);
                    currentCoordinate[1]=+1;
                }

                // Above we added the first row.
                // The current coordinate is (0, lastelement) of the subarrray.
                // we need to take the the the last element of the left most column

                for(var i = 0; i < matrix.Length - 1; i++){

                }
            }

            return default;
        }
    }   
}


