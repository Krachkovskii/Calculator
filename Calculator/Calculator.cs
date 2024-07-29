using System.Numerics;

namespace CalculatorProject.Calculator;

public static class Calculator
{
    public static UInt16 Precision
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
        if (y == 0)
        {
            throw new DivideByZeroException();
        }
        return Math.Round((x / y), Precision);
    }

    public static double Power(double x, double y)
    {
        return Math.Round(Math.Pow(x, y), Precision);
    }
}
