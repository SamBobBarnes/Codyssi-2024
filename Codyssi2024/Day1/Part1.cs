namespace Codyssi2024.Day1;

public class Part1(): BasePart(1,1)
{
    public override string Run()
    {
        var input = Input().Select(int.Parse).ToList();

        return input.Sum().ToString();
    }
}