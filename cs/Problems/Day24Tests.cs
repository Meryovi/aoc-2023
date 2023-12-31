namespace AOC2023.Problems;

public class Day24Tests
{
    private readonly Day24 sut = new();

    [Theory, InlineData(2)]
    public void TestSet_ShouldYield_Result(int expected)
    {
        var input = InputReader.ReadProblemInput("day24_1");
        var result = sut.Solve(input);

        Assert.Equal(expected, result);
    }

    [Theory, InlineData(20336)]
    public void FullSet_ShouldYield_Result(int expected)
    {
        var input = InputReader.ReadProblemInput("day24_2");
        var result = sut.Solve(input);

        Assert.Equal(expected, result);
    }
}
