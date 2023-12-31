namespace AOC2023.Problems;

public class Day13Tests
{
    private readonly Day13 sut = new();

    [Theory, InlineData(405)]
    public void TestSet_ShouldYield_Result(int expected)
    {
        var input = InputReader.ReadProblemInput("day13_1");
        var result = sut.Solve(input);

        Assert.Equal(expected, result);
    }

    [Theory, InlineData(29213)]
    public void FullSet_ShouldYield_Result(int expected)
    {
        var input = InputReader.ReadProblemInput("day13_2");
        var result = sut.Solve(input);

        Assert.Equal(expected, result);
    }
}
