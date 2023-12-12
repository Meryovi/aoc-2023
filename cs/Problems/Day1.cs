namespace AOC2023.Problems;

public class Day1 : IProblem
{
    public string Name => "Day 1";

    public void Solve()
    {
        var lines = InputReader.ReadDayInput(day: 1).Split(Environment.NewLine);
        int sum = 0;

        for (int x = 0; x < lines.Length; x++)
        {
            int d1 = 0;
            int d2 = 0;

            for (int i = 0, j = lines[x].Length - 1; j >= 0 && (d1 == 0 || d2 == 0); i++, j--)
            {
                if (d1 == 0 && int.TryParse(lines[x][i..(i + 1)], out int v1))
                    d1 = v1;

                if (d2 == 0 && int.TryParse(lines[x][j..(j + 1)], out int v2))
                    d2 = v2;
            }
            sum += d1 * 10 + d2;
        }

        Console.WriteLine(sum);
    }
}