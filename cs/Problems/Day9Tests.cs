namespace AOC2023.Problems;

public class Day9Tests
{
    private readonly Day9 sut = new();

    [Theory, InlineData(114)]
    public void TestSet_ShouldYield_Result(long expected)
    {
        var input = InputReader.ReadProblemInput("day9_1");
        var result = sut.Solve(input);

        Assert.Equal(expected, result);
    }

    [Theory, InlineData(2043183816)]
    public void FullSet_ShouldYield_Result(long expected)
    {
        var input = InputReader.ReadProblemInput("day9_2");
        var result = sut.Solve(input);

        Assert.Equal(expected, result);
    }
}
