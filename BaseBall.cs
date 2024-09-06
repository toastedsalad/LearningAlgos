namespace LearningAlgos;

public class BaseBall
{
// Input: ops = ["5","2","C","D","+"]
// Output: 30
// Explanation:
// "5" - Add 5 to the record, record is now [5].
// "2" - Add 2 to the record, record is now [5, 2].
// "C" - Invalidate and remove the previous score, record is now [5].
// "D" - Add 2 * 5 = 10 to the record, record is now [5, 10].
// "+" - Add 5 + 10 = 15 to the record, record is now [5, 10, 15].
// The total sum is 5 + 10 + 15 = 30.

    public static int CallPoints(string[] operations){
        int[] pointsArray = new int[operations.Length];
        var pointsPointer = 0;
                 
        for(var i = 0; i < operations.Length; i++){
            int currentInt;
            if(int.TryParse(operations[i], out currentInt)){
                pointsArray[pointsPointer] = currentInt;        
                pointsPointer++;
                continue;
            }
            else if(operations[i] == "C"){
                pointsPointer--;
                pointsArray[pointsPointer] = 0;
                continue;
            }
            else if(operations[i] == "D"){
                pointsArray[pointsPointer] = pointsArray[pointsPointer - 1] * 2;
                pointsPointer++;
                continue;
            }
            else {
                pointsArray[pointsPointer] = pointsArray[pointsPointer - 1] + pointsArray[pointsPointer - 2];
                pointsPointer++;
                continue; 
            }

        }

        int points = 0;
        // Instead of Length we could leverage our pointer here.
        // But that is not always true...
        for(var j = pointsArray.Length - 1; j >= 0; j--){
            points+=pointsArray[j];
        }

        return points;
    }
}
