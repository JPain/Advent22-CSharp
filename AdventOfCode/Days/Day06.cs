namespace AdventOfCode;

public class Day06 : BaseDay
{
    private readonly string _input;

    public Day06()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    private string Process(int marker)
    {
        for (int i = marker; i < _input.Length; i++)
        {
            if (new HashSet<char>(_input.Substring(i-marker,marker)).Count == marker) return i.ToString();
        }
        return "0";
    }

    public override ValueTask<string> Solve_1() => new(Process(4));

    public override ValueTask<string> Solve_2() => new(Process(14));
}
