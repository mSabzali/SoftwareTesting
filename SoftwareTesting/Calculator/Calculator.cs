using System.Dynamic;

public class Calculator
{
    public int Sum(int first, int second)
    {
        return first + second;
    }

    public (int resutl, int remain) Divide(int first, int second)
    {
        if (second == 0)
            throw new DivideByZeroException();
        return (first / second, first % second);
    }

    public int Multi(int first, int second)
    {
        return first * second;
    }

    public int Subtract(int first, int second)
    {
        return first - second;
    }
}

public static class CalculatorExtension
{
    public static int PulseFourExtension(this int a)
    {
        return a + 4;
    }
}

public interface IMoqClassWrapper
{
    int FourPlus(int a);
}

public class MoqClassWrapper : IMoqClassWrapper
{
    public int FourPlus(int a)
    {
        return a.PulseFourExtension();
    }
}