namespace AdventOfCode;

public class Day00 : BaseDay
{
    private readonly string _input;

    public Day00()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    public override ValueTask<string> Solve_1() => new($"There's nothing here");

    public override ValueTask<string> Solve_2() => new($"There's nothing here");
}
