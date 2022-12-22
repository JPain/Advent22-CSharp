namespace AdventOfCode;

public class Day01 : BaseDay
{
    private readonly string _input;

    public Day01()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    private string Part1()
    {
        int maxCalories = 0;
        foreach (string block in _input.Split("\r\n\r\n"))
        {
            int blockCalories = 0;
            foreach (string calorie in block.Split("\r\n"))
            {
                if (!string.IsNullOrWhiteSpace(calorie)) blockCalories += int.Parse(calorie);
            }
            if (blockCalories > maxCalories) maxCalories = blockCalories;
            blockCalories = 0;
        }
        return maxCalories.ToString();
    }

    public override ValueTask<string> Solve_1() => new(Part1());

    public override ValueTask<string> Solve_2() => new($"TBC");
}
