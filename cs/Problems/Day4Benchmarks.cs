namespace AOC2023.Problems;

[MemoryDiagnoser, ShortRunJob]
[MinColumn, MaxColumn]
public class Day4Benchmarks
{
    private readonly Day4 problem = new();

    private readonly string input = InputReader.ReadProblemInput("day4_1");

    [Benchmark(Description = "Day4 problem")]
    public void Measure() => problem.Solve(input);
}
