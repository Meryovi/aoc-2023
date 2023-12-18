namespace AOC2023.Problems;

[MemoryDiagnoser, ShortRunJob]
[MinColumn, MaxColumn]
public class Day9Benchmarks
{
    private readonly Day9 problem = new();

    private readonly string input = InputReader.ReadProblemInput("day9_1");

    [Benchmark(Description = "Day9 problem")]
    public void Measure() => problem.Solve(input);
}
