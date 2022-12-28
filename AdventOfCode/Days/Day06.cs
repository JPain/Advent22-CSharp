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
            if (new HashSet<char>(){_input[i-4], _input[i-3],_input[i-2],_input[i-1]}.Count == 4)
            {
                return i.ToString();
            }
        }
        return "0";
    }

    public override ValueTask<string> Solve_1() => new(Process());

    public override ValueTask<string> Solve_2() => new($"There's nothing here");
}
