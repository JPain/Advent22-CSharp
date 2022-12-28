namespace AdventOfCode;

public class Day05 : BaseDay
{
    private readonly string _input;

    public Day05()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    private string Part1()
    {
        List<Stack<string>> stacks = new List<Stack<string>>();
        for (int i = 0; i < 9; i++) stacks.Add(new Stack<string>());
        foreach (var line in _input.Split(Environment.NewLine))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            if (line[0] == '[')
            {
                for (int i = 0; i < 9; i++)
                {
                    var cursor = 4 * i;
                    if (line[cursor] == '[')
                    {
                        stacks[i].Push(line[cursor + 1].ToString());
                    }
                }
            }
            else if (line[0] == 'm')
            {
                var command = line.Replace("move ", "").Replace("from ", "").Replace("to ", "").Split();
                var numberToMove = int.Parse(command[0]);
                var fromStackNum = int.Parse(command[1]) - 1;
                var toStackNum = int.Parse(command[2]) - 1;
                for (int i = 0; i < numberToMove; i++)
                {
                    var extractedItem = stacks[fromStackNum].Pop();
                    stacks[toStackNum].Push(extractedItem);
                }
            }
            else if (line[1] == '1')
            {
                //for (int i = 0; i < 9; i++) stacks[i] = 
            }
        }

        var result = "";
        foreach (var stack in stacks)
        {
            result += stack.Pop();
        }
        return result;
    }

    public override ValueTask<string> Solve_1() => new(Part1());

    public override ValueTask<string> Solve_2() => new($"There's nothing here");
}
