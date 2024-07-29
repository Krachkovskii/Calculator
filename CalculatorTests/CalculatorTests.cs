using Xunit;

namespace First_UnitTest.CalculatorTests;

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
    public void Subtract_Doubles()
    {
        var expected = 0.3d;
        var actual = Calculator.Calculator.Subtract(2.5, 2.2);
        Assert.Equal(expected, actual);
    }
}
