namespace LearningAlgos;

using System;

public class BinaryAddition {
    public static string AddBinaryWithConversions(string a, string b) {
        int numbera = Convert.ToInt32(a, 2);
        int numberb = Convert.ToInt32(b, 2);
        var sum = numbera + numberb;

        return Convert.ToString(sum, 2);
    }

    public static string AddBinary(string a, string b) {
        int maxLength = Math.Max(a.Length, b.Length);
        a = a.PadLeft(maxLength, '0');
        b = b.PadLeft(maxLength, '0');

        string result = "";
        int carry = 0;

        for (var i = maxLength - 1; i >= 0; i--) {
            // This is very funky
            int bitA = a[i] - '0';
            int bitB = b[i] - '0';
            int sum = bitA + bitB + carry;
            result = (sum % 2) + result;
            carry = sum / 2;
        }

        if (carry > 0) {
            result = carry + result;
        }

        Console.WriteLine(result);

        return result;
    }
}
