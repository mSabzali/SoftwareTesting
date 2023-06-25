using Xunit;
using Assert = NUnit.Framework.Assert;

namespace CalculatorTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Fact]
    public void Sum()
    {
        //arrange
        Calculator calculator = new();

        //act
        var sum = calculator.Sum(4, 5);

        //assert
        Assert.AreEqual(9, sum);
    }

    [Fact]
    public void Divide()
    {
        //arrange
        Calculator calculator = new();

        //act
        var result = calculator.Divide(10, 5);

        //assert
        Assert.AreEqual((2, 0), result);
    }
}