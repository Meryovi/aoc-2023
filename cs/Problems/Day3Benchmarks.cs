namespace AOC2023.Problems;

[MemoryDiagnoser, ShortRunJob]
[MinColumn, MaxColumn]
public class Day3Benchmarks
{
    private readonly Day3 problem = new();

    private readonly string input = InputReader.ReadProblemInput("day3_1");

    [Benchmark(Description = "Day3 problem")]
    public void Measure() => problem.Solve(input);
}
