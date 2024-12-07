namespace LearningAlgos;

public class PointsInStraightLine {
    public static bool CheckStraightLine(int[][] coordinates) {

        // Given two points [[1, 2], [2, 3]]
        // y change = 3 - 2 = 1
        // x change = 2 - 1 = 1

        var yChange = coordinates[1][1] - coordinates[0][1];
        var xChange = coordinates[1][0] - coordinates[0][0];
        
        // Calculate coefficient
        // m = 1/1 = 1

        // Address division by zero.
        if (xChange == 0) {
            for (var i = 2; i < coordinates.Length; i++) {
                if (coordinates[i][0] != coordinates[0][0]) {
                    return false;
                }
            }
            return true;
     
        }

        decimal m = (decimal)yChange / (decimal)xChange;

        var y1 = coordinates[0][1];
        var x1 = coordinates[0][0];
        var b = y1 - m*x1;

        for (var i = 2; i < coordinates.Length; i++) {
            if(coordinates[i][1] != m*coordinates[i][0] + b)
                return false;
        }

        return true;
    }
}
