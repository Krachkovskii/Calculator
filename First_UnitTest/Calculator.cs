using System.Numerics;

namespace First_UnitTest.Calculator;

public static class Calculator
{
    public static int Precision
    {
        get; set;
    } = 5;

    public static double Add(double x, double y)
    {
        return Math.Round((x + y), Precision);
    }

    public static double Subtract(double x, double y)
    {
        return Math.Round((x - y), Precision);
    }

    public static double Multiply(double x, double y)
    {
        return Math.Round((x * y), Precision);
    }

    public static double Divide(double x, double y)
    {
        return Math.Round((x / y), Precision);
    }

    public static double Power(double x, double y)
    {
        return Math.Round(Math.Pow(x, y), Precision);
    }
}
