namespace Codyssi2024.Day3;

public class Part1() : BasePart(3,1)
{
    public override string Run()
    {
        var input = Input().Select(line => line.Split(' ')[1]).Sum(int.Parse);

        return input.ToString();
    }
}