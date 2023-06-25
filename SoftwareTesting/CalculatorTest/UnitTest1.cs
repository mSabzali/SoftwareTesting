using Xunit;

namespace CalculatorTest;

public class Tests
{
    [Xunit.Theory]
    [InlineData(2, 2, 4)]
    [InlineData(2, 3, 5)]
    public void Sum(int a, int b, int e)
    {
        //arrange
        Calculator calculator = new();

        //act
        var sum = calculator.Sum(a, b);

        //assert
        Assert.Equal(e, sum);
    }

    [Fact]
    public void Divide()
    {
        //arrange
        Calculator calculator = new();

        //act
        var result = calculator.Divide(10, 5);

        //assert
        Assert.Equal((2, 0), result);
    }

    [Fact]
    public void TestMulti()
    {
        //arrange
        Calculator calculator = new();

        //act
        var result = calculator.Multi(10, 5);

        //assert
        Assert.Equal(50, result);
    }

    // [Fact]
    // public void DivideException()
    // {
    //     //arrange
    //     Calculator calculator = new();
    //
    //     //act
    //     //var result = calculator.Divide(10, 0);
    //
    //     //assert
    //     //Assert.Throws<DivideByZeroException>(result);
    //     Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
    // }
}