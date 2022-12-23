namespace AdventOfCode.Tests;

public class Tests
{
    [Theory]
    [InlineData(typeof(Day01), "68292", "203203")]
    [InlineData(typeof(Day02), "15422", "15442")]
    public async Task DayTests(Type type, string sol1, string sol2)
    {
        if (Activator.CreateInstance(type) is BaseProblem instance)
        {
            Assert.Equal(sol1, await instance.Solve_1());
            Assert.Equal(sol2, await instance.Solve_2());
        }
    }
}