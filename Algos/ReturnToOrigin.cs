namespace LearningAlgos{
    public class ReturnToOrigin{
        public static bool JudgeCircle(string moves) {
            var startPoint = new int[2];  

            for(var i = 0; i < moves.Length; i++){
                if(moves[i] == 'U'){
                    startPoint[0]+=1;
                }
                else if(moves[i] == 'D'){
                    startPoint[0]-=1;
                }
                else if(moves[i] == 'R'){
                    startPoint[1]+=1;
                }
                else{
                    startPoint[1]-=1;
                }
            }

            if(startPoint[0] == 0 && startPoint[1] == 0){
                return true;
            };
            return false;
        }
    }
}
