namespace LearningAlgos
{
    public class BubbleSort
    {
       public static void SortBubbly(int[] numsArray)
       {    
            // We will need a search scope that should decrement with each iteration.
            // We also need pair idexes for first and second members.

            var searchScope = numsArray.Length;
            
            while(searchScope > 1)
            {
                for (int i = 0, j = 1; j < searchScope; i++, j++)
                {
                    // If i is bigger than j we swap. Else we just increment.
                    if (numsArray[i] > numsArray[j])
                    {
                        var firstValue = numsArray[i];
                        var secondValue = numsArray[j];
                        numsArray[i] = secondValue;
                        numsArray[j] = firstValue;
                    }
                }
                searchScope -= 1;
            }

            // Yeah managed to do this algo without help of others.
            // It actually is attainable for my monkey brains.
       } 
    }
}
