namespace AdventOfCode;

public class Day01 : BaseDay
{
    private readonly string _input;

    public Day01()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    private string CountTotalCalories(int totalsToCount)
    {
        List<int> caloriesList = new List<int>();
        foreach (string block in _input.Split($"{Environment.NewLine}{Environment.NewLine}"))
        {
            int blockCalories = 0;
            foreach (string calorie in block.Split($"{Environment.NewLine}"))
            {
                if (!string.IsNullOrWhiteSpace(calorie)) blockCalories += int.Parse(calorie);
            }
            caloriesList.Add(blockCalories);
            blockCalories = 0;
        }
        caloriesList.Sort();
        caloriesList.Reverse();
        int maxCalories = 0;
        for (int i = 0; i < totalsToCount; i++)
        {
            maxCalories += caloriesList[i];
        }
        
        return maxCalories.ToString();
    }

    public override ValueTask<string> Solve_1() => new(CountTotalCalories(1));

    public override ValueTask<string> Solve_2() => new(CountTotalCalories(3));
}
