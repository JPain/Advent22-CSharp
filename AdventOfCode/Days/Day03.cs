namespace AdventOfCode;

public class Day03 : BaseDay
{
    private readonly string _input;

    public Day03()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    private string Part1()
    {
        var score = 0;

        foreach (var line in _input.Split(Environment.NewLine))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            var compartmentA = line.Substring(0,line.Length / 2);
            var compartmentB = line.Substring(line.Length / 2);

            var oddOneOut = compartmentA.Intersect(compartmentB).First();

            if (char.IsUpper(oddOneOut)) score += ((short)oddOneOut - 38);
            else score += ((short)oddOneOut - 96);
        }
        return score.ToString();
    }

    private string Part2()
    {
        var score = 0;

        var lines = _input.Split(Environment.NewLine);

        for (int i = 0; i < lines.Length-1; i+=3)
        {
            var group1 = lines[i];
            var group2 = lines[i+1];
            var group3 = lines[i+2];

            var oddOneOut = group1.Intersect(group2.Intersect(group3)).First();

            if (char.IsUpper(oddOneOut)) score += ((short)oddOneOut - 38);
            else score += ((short)oddOneOut - 96);
        }

        return score.ToString();
    }

    public override ValueTask<string> Solve_1() => new(Part1());

    public override ValueTask<string> Solve_2() => new(Part2());
}
