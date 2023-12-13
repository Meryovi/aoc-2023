namespace AOC2023.Problems;

public class Day4 : IProblem
{
    public string Name => "Day 4";

    public void Solve()
    {
        string input = InputReader.ReadDayInput(day: 4);
        int scratchCardPoints = CalculateScratchCardPoints(input);

        Console.WriteLine(scratchCardPoints);
    }

    private static int CalculateScratchCardPoints(ReadOnlySpan<char> input)
    {
        int cardPoints = 0;
        Span<Range> gameLines = stackalloc Range[200];

        int count = input.Split(gameLines, Environment.NewLine);
        for (int i = 0; i < count; i++)
        {
            var game = input[gameLines[i]];
            var numbers = game[(game.IndexOf(":") + 1)..];

            var separator = numbers.IndexOf('|');
            var winnersSlice = numbers[..(separator - 1)];
            var foundSlice = numbers[(separator + 1)..];

            int gamePoints = 0;
            for (int j = 0; j < foundSlice.Length; j += 3)
            {
                bool exists = winnersSlice.Contains(foundSlice[j..(j + 3)], StringComparison.Ordinal);
                gamePoints = exists ? Math.Max(1, gamePoints * 2) : gamePoints;
            }

            cardPoints += gamePoints;
        }

        return cardPoints;
    }
}