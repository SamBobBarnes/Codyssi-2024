namespace Codyssi2024.Day1;

public class Part2(): BasePart(1,2)
{
    public override void Run()
    {
        var input = Input().Select(int.Parse).ToList();
        const int vouchers = 20;

        for(int i = 0; i < vouchers; i++)
        {
            var max = input.Max();
            input.Remove(max);
        }

        Console.WriteLine(input.Sum());
    }
}