namespace AdventOfCode;

public class Day02 : BaseDay
{
    private readonly string _input;

    public Day02()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    private string Part1()
    {
        Dictionary<(char, char), int> answers = new Dictionary<(char, char), int>(){
            {('A', 'X'), 4}, //rock rock 1 = draw 3
            {('A', 'Y'), 8}, //rock paper 2 = win 6
            {('A', 'Z'), 3}, //rock sissors 3 = lose 0
            {('B', 'X'), 1}, //paper rock 1 = lose 0
            {('B', 'Y'), 5}, //paper paper 2 = draw 3
            {('B', 'Z'), 9}, //paper sissors 3 = win 6
            {('C', 'X'), 7}, //sissors rock 1 = win 6
            {('C', 'Y'), 2}, //sissors paper 2 = lose 0
            {('C', 'Z'), 6}, //sissors sissors 3 = draw 3
        };
        int score = 0;
        foreach (string line in _input.Split(Environment.NewLine))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            score += answers[(line[0],line[2])];
        }
        return score.ToString();
    }

    private string Part2()
    {
        Dictionary<(char, char), int> answers = new Dictionary<(char, char), int>(){
            {('A', 'X'), 3}, //rock sissors 3 = lose 0
            {('A', 'Y'), 4}, //rock rock 1 = draw 3
            {('A', 'Z'), 8}, //rock paper 2 = win 6
            {('B', 'X'), 1}, //paper rock 1 = lose 0
            {('B', 'Y'), 5}, //paper paper 2 = draw 3
            {('B', 'Z'), 9}, //paper sissors 3 = win 6
            {('C', 'X'), 2}, //sissors paper 2 = lose 0
            {('C', 'Y'), 6}, //sissors sissors 3 = draw 3
            {('C', 'Z'), 7}, //sissors rock 1 = win 6
        };
        int score = 0;
        foreach (string line in _input.Split(Environment.NewLine))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            score += answers[(line[0],line[2])];
        }
        return score.ToString();
    }

    public override ValueTask<string> Solve_1() => new(Part1());

    public override ValueTask<string> Solve_2() => new(Part2());
}

