namespace AdventOfCode;

public class Day05 : BaseDay
{
    private readonly string _input;

    public Day05()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    private string Process(int craneModel)
    {
        var stacks = new Stack<string>[9];
        for (int i = 0; i < 9; i++) stacks[i] = new Stack<string>();
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

                if (craneModel == 9000)
                {
                    for (int i = 0; i < numberToMove; i++)
                    {
                        var extractedItem = stacks[fromStackNum].Pop();
                        stacks[toStackNum].Push(extractedItem);
                    }
                }
                else if (craneModel == 9001)
                {
                    var tempStack = new Stack<string>();
                    for (int i = 0; i < numberToMove; i++)
                    {
                        tempStack.Push(stacks[fromStackNum].Pop());
                    }
                    while (tempStack.Count > 0)
                    {
                        stacks[toStackNum].Push(tempStack.Pop());
                    }
                }
                else
                {
                    return "what?";
                }

            }
            else if (line[1] == '1')
            {
                var newStacks = new Stack<string>[9];
                for (int i = 0; i < 9; i++)
                {
                    newStacks[i] = new Stack<string>();
                    while (stacks[i].Count > 0) newStacks[i].Push(stacks[i].Pop());
                }
                stacks = newStacks;
            }
        }

        var result = "";
        foreach (var stack in stacks)
        {
            result += stack.Pop();
        }
        return result;
    }

    public override ValueTask<string> Solve_1() => new(Process(9000));

    public override ValueTask<string> Solve_2() => new(Process(9001));
}
