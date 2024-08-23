using System;
using System.Collections.Generic;

namespace LearningAlgos;

public class RomanInt
{
    // Whar are enums for? 
    public enum RomanNumeral
    {
        I = 1,
        V = 5,
        X = 10,
        L = 50,
        C = 100,
        D = 500,
        M = 1000
    }
    
    
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
            {"M", 100}
        };

        int result = 0;

        for(int j = 0; j < s.Length; j++)
        {
            var currentNumner = RomanNumeral.s[j];
        }
        return 0;
    }
}
