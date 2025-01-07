using System;

namespace LearningAlgos;

public static class StringMultiplier {
    public static string Multiply(string num1, string num2) {
        // 123
        //   4
        var carry = 0;
        var result = "yo";
        for (var i = num1.Length - 1; i <= 0; i--) {
            int dig1 = GetDigit(num1[i]);
            int dig2 = GetDigit(num2[0]);
            var interResult = dig1 * dig2;
            var stringResult = interResult.ToString();
            
            if (interResult > 9) {
                result = stringResult[1] + result;
                carry = GetDigit(stringResult[0]);
            } 
            else {
                result = stringResult[0] + result;
            }
        }

        Console.WriteLine(result);
        return result;
    }
    public static int GetDigit(char charDig) {

        switch (charDig) { 
            case '1': return 1;
            case '2': return 2;
            case '3': return 3;
            case '4': return 4;
            case '5': return 5;
            case '6': return 6;
            case '7': return 7;
            case '8': return 8;
            case '9': return 9;
        }
        return 0;
    }
}
