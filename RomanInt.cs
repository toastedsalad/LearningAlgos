using System;
using System.Collections.Generic;

namespace LearningAlgos;

public class RomanInt
{
    
    public static int RomanToInt(string s)
    {
        var romanRumeral = new Dictionary<string, int>() 
        {
            {"I", 1},
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000}
        };

        int result = 0;
        var i = 0;

        for(; i < s.Length; i++)
        {
            var indexOne = i;
            var indexTwo = i + 1;
            var intOne = romanRumeral[s[indexOne].ToString()];
            if(indexTwo == s.Length)
            {
                indexTwo = indexOne;
            }
            var intTwo = romanRumeral[s[indexTwo].ToString()];
            
            if (intOne > intTwo)
            {
                result += intOne;
            }
            else if (intOne < intTwo)
            {
                result += intTwo - intOne;
                i++;
            }
            else if (intOne == intTwo)
            {
                result += intOne;
            }
        }

        Console.WriteLine($"This is the number: {result}");
        return result;
    }
}
