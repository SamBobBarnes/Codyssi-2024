namespace Codyssi2024.Day1;

public class Part1(): BasePart(1,1)
{
    public override void Run()
    {
        var input = Input().Select(int.Parse).ToList();

        Console.WriteLine(input.Sum());
    }
}