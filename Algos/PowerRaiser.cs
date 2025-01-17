using System;

namespace LearningAlgos;

public class PowPow {
    public double MyPow(double x, int n) {
        var result = Math.Pow(x, n);
        return result;
    }
}


public class PowPowLoop {
    public double MyPow(double x, int n) {
        double result = default!;

        if (x == 1) {
            result =+ x;
            return result;
        }

        if (x == -1) {
            if (n % 2 == 0) {
                result =+ 1;
                return result;
            }
            result =+ -1;
            return result;
        }

        if (n == 0) {
            result = 1;
            return result;
        }

        if (n > 0) {
            if (n == 1) {
                result =+ x;
                return result;
            }

            for (var i = 1; i < n; i++) {
                if (i == 1) {
                    result += x*x;
                    continue;
                }
                result = result * x;
            }

            return result;
        }

        if (n == -1) {
            result =+ x;
            return 1/result;
        }

        for (var i = 1; i < n*-1; i++) {
            if (i == 1) {
                result += x*x;
                continue;
            }
            result = result * x;
        }

        return 1/result;
    }
}
