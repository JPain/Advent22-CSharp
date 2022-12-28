namespace AdventOfCode;

public class Day06 : BaseDay
{
    private readonly string _input;

    public Day06()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    private string Process()
    {
        for (int i = 4; i < _input.Length; i++)
        {
            HashSet<string> set = new HashSet<string>() { };


        }
        return "There's nothing here";
    }

    public override ValueTask<string> Solve_1() => new(Process());

    public override ValueTask<string> Solve_2() => new($"There's nothing here");
}
