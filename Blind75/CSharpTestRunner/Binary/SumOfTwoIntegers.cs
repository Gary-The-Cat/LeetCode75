using _371_SumOfTwoIntegers;

namespace TestRunner.Binary;

public class SumOfTwoIntegers
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 3, 5)]
    [InlineData(-1, 1, -0)]
    [InlineData(-12, -8, -20)]
    public void Run(int a, int b, int expected) => IntegerMath.Sum(a, b).Should().Be(expected);
}