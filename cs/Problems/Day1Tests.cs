namespace AOC2023.Problems;

public class Day1Tests
{
    private readonly Day1 sut = new();

    [Theory, InlineData(142)]
    public void TestSet_ShouldYield_Result(int expected)
    {
        var input = InputReader.ReadProblemInput("day1_1");
        var result = sut.Solve(input);

        Assert.Equal(expected, result);
    }

    [Theory, InlineData(55017)]
    public void FullSet_ShouldYield_Result(int expected)
    {
        var input = InputReader.ReadProblemInput("day1_2");
        var result = sut.Solve(input);

        Assert.Equal(expected, result);
    }
}
