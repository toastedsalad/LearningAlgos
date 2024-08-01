using System;

namespace LearningAlgos
{
    public class ArrayGenerator
    {
        public static int[] GenerateArray(int arrayLength)
        {   
            var generatedArray = new int[arrayLength];
            var randomObject = new Random();
            var minValue = -50;
            var maxValue = 50;

            for (int i = 0; i < arrayLength; i++)
            {
                generatedArray[i] = randomObject.Next(minValue, maxValue);
            }
            
            return generatedArray;
        }
    }
}
