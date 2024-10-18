namespace LearningAlgos{
    public class RichestCustomerWealth{
        public int MaximumWealth(int[][] accounts){
            var maxWealth = 0;
            var wealth = 0;
        
            for(var i = 0; i < accounts.Length; i++){
                for(int j = 0; j < accounts[i].Length; j++){
                    wealth+=accounts[i][j];
                }
                if(wealth > maxWealth){
                    maxWealth = wealth;
                }
                wealth = 0;
            } 
           
            return maxWealth;
        }
    }
}
