using Xunit;

namespace CalculatorProject.CalculatorTests;

public class CalculatorTests
{
    [Theory]
    [InlineData(2d, 3d, 5d)]
    [InlineData(-5d, -1d, -6d)]
    [InlineData(0, 0, 0)]
    [InlineData(1.35, 2.95, 4.3)]
    public void Add(double x, double y, double expected)
    {
        var actual = Calculator.Calculator.Add(x, y);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(3d, 3d, 0)]
    [InlineData(5.1d, 0.1d, 5d)]
    [InlineData(3d, 9d, -6d)]
    public void Subtract(double x, double y, double expected)
    {
        var actual = Calculator.Calculator.Subtract(x, y);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void DivideByZero()
    {
        var ex = Assert.Throws<DivideByZeroException>(() => Calculator.Calculator.Divide(5, 0));
    }

    [Theory]
    [InlineData(3, 2, 2)]
    public void Subtract_Doubles(double x, double y, double expected)
    {
        var actual = Calculator.Calculator.Subtract(x, y);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(25, 0, 1)]
    [InlineData(3, 1, 3)]
    [InlineData(25, 0.5, 5)]
    public void Power_Test(double num, double power, double expected)
    {
        var actual = Calculator.Calculator.Power(num, power);
        Assert.Equal(expected, actual);
    }
}
