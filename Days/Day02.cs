namespace AdventOfCode;

public class Day02 : BaseDay
{
    private readonly string _input;

    public Day02()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    /*
    A - Rock        X - Rock
    B - Paper       Y - Paper
    C - Sissors     Z - Sissors
    */

    private string Process()
    {

        return "Nothing here yet";
    }

    private bool didWin(char call, char response)
    {

        return false;
    }

    public override ValueTask<string> Solve_1() => new(Process());

    public override ValueTask<string> Solve_2() => new($"I'm just a string");
}

class RPSGame
{
    (TheirChoice, MyChoice) roundChoices;

    public bool didWin
    {
        get 
        {
            if (roundChoices.Item1 == roundChoices.Item2) {

            }
            return true;
        }
        set { return; }
    }
    

    public RPSGame(char theirChoice, char myChoice){
        roundChoices = ((TheirChoice)theirChoice, (MyChoice)myChoice);
    }

    enum TheirChoice
    {
        Rock = 'A',
        Papper = 'B',
        Sissors = 'C'
    }
    enum MyChoice
    {
        Rock = 'X',
        Papper = 'Y',
        Sissors = 'Z'
    }

    

}