using System;

namespace LearningAlgos;

public class LengthOfLastString
{
    public static int GetLengthOfLastWord(string s)
    {
        // Take the length of string. start iterating from the end for string till ' '
        var wordLength = 0;

        var i = s.Length - 1;
        for(; i >= 0 ; i--)
        {
            // Check if it is space, if so then continue;
            if(s[i] == ' ')
            {
                continue;
            }
            else
            {
                for(; i >= 0; i--)
                {
                    if(s[i] != ' ')
                    {
                        wordLength++;
                    }
                    else
                    {
                        return wordLength;
                    }
                }
            }
        } 

        return wordLength; 
    }
}
