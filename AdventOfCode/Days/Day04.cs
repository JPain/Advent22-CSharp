namespace AdventOfCode;

public class Day04 : BaseDay
{
    private readonly string _input;

    public Day04()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    private string Part1()
    {
        int count = 0;

        foreach (var line in _input.Split(Environment.NewLine))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            var twoFields = line.Split(',');
            var (Zone1, Zone2) = (new Field(twoFields[0]), new Field(twoFields[1]));

            if (Zone1.isContained(Zone2) || Zone2.isContained(Zone1)) count++;
        }
        return count.ToString();
    }

    private string Part2()
    {
        int count = 0;

        foreach (var line in _input.Split(Environment.NewLine))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            var twoFields = line.Split(',');
            var (Zone1, Zone2) = (new Field(twoFields[0]), new Field(twoFields[1]));

            if (Zone1.isOverlap(Zone2) || Zone2.isOverlap(Zone1)) count++;
        }
        return count.ToString();
    }

    struct Field
    {
        public int A { get; private set; }
        public int B { get; private set; }

        public Field(int A, int B){
            this.A = A;
            this.B = B;
        }

        public Field(string input){
            var parsed = input.Split('-');
            this.A = int.Parse(parsed[0]);
            this.B = int.Parse(parsed[1]);
        }

        public bool isContained(Field fieldCheck)
        {
            if (this.A >= fieldCheck.A && this.B <= fieldCheck.B) return true;
            return false;
        }

        public bool isOverlap(Field fieldCheck)
        {
            if (this.A <= fieldCheck.A && fieldCheck.A <= this.B) return true;
            if (this.A <= fieldCheck.B && fieldCheck.B <= this.B) return true;
            return false;
        }
    }

    public override ValueTask<string> Solve_1() => new(Part1());

    public override ValueTask<string> Solve_2() => new(Part2());
}
